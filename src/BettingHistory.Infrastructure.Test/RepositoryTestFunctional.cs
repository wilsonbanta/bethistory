using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Model;
using NUnit.Framework;

namespace BettingHistory.Infrastructure.Test
{
	[TestFixture]
	public class RepositoryTestFunctional
	{
		readonly Repository _repository = new Repository();
		List<BetHistory> _settled = new List<BetHistory>();

		[OneTimeSetUp]
		public void Setup()
		{
			_settled = _repository.GetSettledHistory().ToList();
		}

		[Test]
		public void should_get_settled_history()
		{
			Assert.IsTrue(_settled.Count > 0);
		}
	}
}
