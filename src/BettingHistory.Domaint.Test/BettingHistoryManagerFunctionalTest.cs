using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Domain;

namespace BettingHistory.Domaint.Test
{
	[TestFixture]
	public class BettingHistoryManagerFunctionalTest
	{
		private  IBettingHistoryManager _manager;
		[OneTimeSetUp]
		public void Setup()
		{
			_manager = new BettingHistoryManager();
		}

		[Test]
		public void should_get_unusual_settled_winnings()
		{
			var items = _manager.GetSettledUnusualWinnings();
			Assert.NotNull(items);
		}

		[Test]
		public void should_get_unusual_unsettled_winnings()
		{
			var items = _manager.GetUnSettledUnusualWinnings();
			Assert.NotNull(items);
		}

		[Test]
		public void should_get_average_bet_risk()
		{
			var items = _manager.GetAverageBetsRisks();
			Assert.NotNull(items);
		}

		[Test]
		public void should_get_high_winning_risk()
		{
			var items = _manager.GetHighWinningStakesFromUnsettled();
			Assert.NotNull(items);
		}
	}
}
