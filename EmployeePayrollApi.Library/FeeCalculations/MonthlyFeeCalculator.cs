namespace EmployeePayrollApi.Library.FeeCalculations
{
	public class MonthlyFeeCalculator : IFeeCalculator
	{
		public decimal MonthlyFee { get; set; }

		public MonthlyFeeCalculator() { }

		public MonthlyFeeCalculator(decimal monthlyFee)
		{
			this.MonthlyFee = monthlyFee;
		}

		public decimal Calculate()
		{
			return this.MonthlyFee;
		}
	}
}