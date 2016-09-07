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
		public void test()
		{
			var test = _manager.GetUnusualWinnings();
		}
	}
}
