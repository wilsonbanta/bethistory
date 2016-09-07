using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Dto;
using BettingHistory.Infrastructure;
using BettingHistory.Model;

namespace BettingHistory.Domain
{
	public class BettingHistoryManager : IBettingHistoryManager
	{
		private readonly IRepository _repository;
		public BettingHistoryManager()
		{
			_repository = new Repository();
		}

		public List<UnusualWinning> GetSettledUnusualWinnings()
		{
			return GetUnusualWinnings(_repository.GetSettledHistory());
		}

		public List<UnusualWinning> GetUnSettledUnusualWinnings()
		{
			return GetUnusualWinnings(_repository.GetUnSettleds());
		}

		public List<AverageBetsRisk> GetAverageBetsRisks()
		{
			var betHistory = _repository.GetSettledHistory();
			var currentHistory = _repository.GetUnSettleds();
			var result = new List<AverageBetsRisk>();
			 
			var betHistoryItems = betHistory.GroupBy(x => x.Customer).Select(x => new
			{
				Customer = x.Key,
				CurrentStakes = x.Average(y=> y.Stake)
			}).ToList();

			currentHistory.ForEach(x =>
			{
				var item = new AverageBetsRisk
				{
					Customer = x.Customer,
					CurrentStakes = x.Stake,
					IncreaseStakes = 100
				};

				var prevItem = betHistoryItems.FirstOrDefault(z => z.Customer == x.Customer);

				if (prevItem != null)
				{
					item.PreviousStakes = prevItem.CurrentStakes;
					item.IncreaseStakes = item.CurrentStakes/prevItem.CurrentStakes;
				}

				result.Add(item);
			});

			return result.Where(x=> x.IncreaseStakes >= 10).ToList();
		}

		public List<HighWinningStake> GetHighWinningStakesFromUnsettled()
		{
			return _repository.GetUnSettleds().Where(x => x.Win >= 1000).Select(x => new HighWinningStake
			{
				Customer = x.Customer,
				Stake = x.Stake,
				ToWin = x.Win
			}).ToList();
		}


		private List<UnusualWinning> GetUnusualWinnings(List<BetHistory> betHistories)
		{
			var obj = betHistories.GroupBy(x => x.Customer).Select(x => new
			{
				Customer = x.Key,
				NumberOfBet = x.Count(),
				NumberOfWinnings = x.Count(c => c.Win > 0)
			}).Where(x => ((decimal) x.NumberOfWinnings/(decimal) x.NumberOfBet)*100 > 60)
				.Select(x => new UnusualWinning
				{
					Customer = x.Customer,
					NumberOfWinnings = x.NumberOfWinnings,
					NumberOfBet = x.NumberOfBet,
					Percentage = ((decimal) x.NumberOfWinnings/ (decimal)x.NumberOfBet)*100
				});

			return obj.ToList();
		}
	}
}
