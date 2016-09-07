using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BettingHistory.Dto
{
	public class AverageBetsRisk
	{
		public int Customer { get; set; }	
		public decimal PreviousStakes { get; set; }
		public decimal CurrentStakes { get; set; }
		public decimal IncreaseStakes { get; set; }
	}
}
