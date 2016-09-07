using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingHistory.Dto
{
    public class UnusualWinning
    {
	    public int Customer { get; set; }
	    public int NumberOfBet { get; set; }
		public int NumberOfWinnings { get; set; }
		public decimal Percentage { get; set; }
    }
}
