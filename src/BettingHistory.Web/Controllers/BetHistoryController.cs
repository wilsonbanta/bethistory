using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BettingHistory.Domain;
using BettingHistory.Web.Models;

namespace BettingHistory.Web.Controllers
{
	public class BetHistoryController : Controller
	{
		IBettingHistoryManager _manager = new BettingHistoryManager();
		// GET: BetHistory
		public ActionResult Index()
		{
			var viewModel = new RiskViewModel();
			viewModel.UnusualSettledWinnings = _manager.GetSettledUnusualWinnings();
			viewModel.UnusualUnsettledWinnings = _manager.GetUnSettledUnusualWinnings();
			viewModel.AverageBetsRisks = _manager.GetAverageBetsRisks();
			return View(viewModel);
		}
	}
}