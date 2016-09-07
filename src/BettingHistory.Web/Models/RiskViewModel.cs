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
	}
}