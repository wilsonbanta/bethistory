using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BettingHistory.Model;
using CsvHelper;

namespace BettingHistory.Infrastructure
{
	public class Repository : IRepository
	{
		public List<BetHistory> GetSettledHistory()
		{
			var result = new List<BetHistory>();
			using (TextReader reader = File.OpenText(System.AppDomain.CurrentDomain.BaseDirectory + "\\" + ConfigurationManager.AppSettings["Settled.Csv"]))
			{
				var csv = new CsvReader(reader);
				while (csv.Read())
				{
					result.Add(new BetHistory
					{
						Customer = csv.GetField<int>(0),
						Event = csv.GetField<int>(1),
						Participant = csv.GetField<int>(2),
						Stake = csv.GetField<decimal>(3),
						Win = csv.GetField<decimal>(4)
					});
				}
			}

			return result;
		}

		public List<BetHistory> GetUnSettleds()
		{
			var result = new List<BetHistory>();
			using (TextReader reader = File.OpenText(System.AppDomain.CurrentDomain.BaseDirectory + "\\" + ConfigurationManager.AppSettings["Unsettled.Csv"]))
			{
				var csv = new CsvReader(reader);
				while (csv.Read())
				{
					result.Add(new BetHistory
					{
						Customer = csv.GetField<int>(0),
						Event = csv.GetField<int>(1),
						Participant = csv.GetField<int>(2),
						Stake = csv.GetField<decimal>(3),
						Win = csv.GetField<decimal>(4)
					});
				}
			}

			return result;
		}
	}
}
