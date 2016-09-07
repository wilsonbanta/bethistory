using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BettingHistory.Dto;

namespace BettingHistory.Web.Models
{
	public class RiskViewModel
	{
		public List<UnusualWinning> UnusualSettledWinnings { get; set; }
		public List<UnusualWinning> UnusualUnsettledWinnings { get; set; }
		public List<AverageBetsRisk> AverageBetsRisks { get; set; }
	}
}