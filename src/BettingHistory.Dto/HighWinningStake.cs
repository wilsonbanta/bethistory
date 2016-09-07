using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BettingHistory.Dto
{
	public class HighWinningStake
	{
		public int Customer { get; set; }
		public decimal Stake { get; set; }
		public decimal ToWin { get; set; }
	}
}
