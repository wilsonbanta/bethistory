﻿using System.Web.Mvc;
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
			viewModel.HighWinningStakes = _manager.GetHighWinningStakesFromUnsettled();
			return View(viewModel);
		}
	}
}