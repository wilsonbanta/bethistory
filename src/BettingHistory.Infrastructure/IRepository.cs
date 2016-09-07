using BettingHistory.Model;
using System.Collections.Generic;

namespace BettingHistory.Infrastructure
{
	public interface IRepository
	{
		List<BetHistory> GetSettledHistory();
		List<BetHistory> GetUnSettleds();
	}
}
