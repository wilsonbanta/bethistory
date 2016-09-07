namespace BettingHistory.Model
{
	public class BetHistory
	{
		public int Customer { get; set; }
		public int Event { get; set; }
		public int Participant { get; set; }
		public decimal Stake { get; set; }
		public decimal Win { get; set; }
	}
}
