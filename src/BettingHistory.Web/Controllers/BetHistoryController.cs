using System.Web.Mvc;
using BettingHistory.Domain;
using BettingHistory.Web.Models;

namespace BettingHistory.Web.Controllers
{
	public class BetHistoryController : Controller
	{
		readonly IBettingHistoryManager _manager = new BettingHistoryManager();
		// GET: BetHistory
		public ActionResult Index()
		{
			var viewModel = new RiskViewModel
			{
				UnusualSettledWinnings = _manager.GetSettledUnusualWinnings(),
				UnusualUnsettledWinnings = _manager.GetUnSettledUnusualWinnings(),
				AverageBetsRisks = _manager.GetAverageBetsRisks(),
				HighWinningStakes = _manager.GetHighWinningStakesFromUnsettled()
			};
			return View(viewModel);
		}
	}
}