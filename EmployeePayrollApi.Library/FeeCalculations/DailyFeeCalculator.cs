namespace EmployeePayrollApi.Library.FeeCalculations
{
	public class DailyFeeCalculator : IFeeCalculator
	{
		public decimal DailyFee { get; set; }

		public decimal WorkingDayCount { get; set; }

		public DailyFeeCalculator() { }

		public DailyFeeCalculator(decimal dailyFee, decimal workingDayCount)
		{
			this.DailyFee = dailyFee;
			this.WorkingDayCount = workingDayCount;
		}

		public decimal Calculate()
		{
			return this.DailyFee * this.WorkingDayCount;
		}
	}
}