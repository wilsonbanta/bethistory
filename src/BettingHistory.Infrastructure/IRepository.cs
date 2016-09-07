using BettingHistory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingHistory.Infrastructure
{
	public interface IRepository
	{
		List<Settled> GetSettledHistory();
		List<UnSettled> GetUnSettleds();
	}
}
