namespace EmployeePayrollApi.Library.FeeCalculations
{
	public class OvertimeFeeCalculator : IFeeCalculator
	{
		public decimal OvertimeHour { get; set; }

		public decimal OvertimeFee { get; set; }

		public OvertimeFeeCalculator() { }

		public OvertimeFeeCalculator(decimal overtimeHour, decimal overtimeFee)
		{
			this.OvertimeHour = overtimeHour;
			this.OvertimeFee = overtimeFee;
		}

		public decimal Calculate()
		{
			return this.OvertimeFee * this.OvertimeHour;
		}
	}
}