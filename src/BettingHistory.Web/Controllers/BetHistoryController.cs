using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BettingHistory.Web.Controllers
{
    public class BetHistoryController : Controller
    {
        // GET: BetHistory
        public ActionResult Index()
        {
            return View();
        }
    }
}