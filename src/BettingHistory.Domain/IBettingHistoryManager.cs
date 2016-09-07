using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Dto;

namespace BettingHistory.Domain
{
	public interface IBettingHistoryManager
	{
		List<UnusualWinning> GetSettledUnusualWinnings();
		List<UnusualWinning> GetUnSettledUnusualWinnings();
		List<AverageBetsRisk> GetAverageBetsRisks();
		List<HighWinningStake> GetHighWinningStakesFromUnsettled();
	}
}
