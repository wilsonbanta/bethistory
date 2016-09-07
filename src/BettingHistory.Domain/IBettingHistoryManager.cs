using System.Collections.Generic;
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
