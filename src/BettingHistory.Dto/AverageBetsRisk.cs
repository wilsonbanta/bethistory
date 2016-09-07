namespace BettingHistory.Dto
{
	public class AverageBetsRisk
	{
		public int Customer { get; set; }	
		public decimal PreviousStakes { get; set; }
		public decimal CurrentStakes { get; set; }
		public decimal IncreaseStakes { get; set; }
	}
}
