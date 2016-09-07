using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Model;

namespace BettingHistory.Infrastructure
{
	public class Repository : IRepository
	{
		public IList<Settled> GetSettledHistory()
		{
			throw new NotImplementedException();
		}

		public IList<UnSettled> GetUnSettleds()
		{
			throw new NotImplementedException();
		}
	}
}
