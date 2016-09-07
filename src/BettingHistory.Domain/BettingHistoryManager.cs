using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

		public List<UnusualWinning> GetUnusualWinnings()
		{
			var obj = _repository.GetSettledHistory().GroupBy(x => x.Customer).Select(x => new
			{
				Customer = x.Key,
				NumberOfBet = x.Count(),
				NumberOfWinnings = x.Count(c => c.Win > 0)
			}).Where(x => ((decimal) x.NumberOfWinnings/(decimal) x.NumberOfBet)*100 > 60);

			return null;
		}
	}
}
