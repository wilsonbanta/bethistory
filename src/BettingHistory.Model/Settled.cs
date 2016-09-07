using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BettingHistory.Model
{
	public class Settled
	{
		public int Customer { get; set; }
		public int Event { get; set; }
		public int Participant { get; set; }
		public decimal Stake { get; set; }
		public decimal Win { get; set; }
	}
}
