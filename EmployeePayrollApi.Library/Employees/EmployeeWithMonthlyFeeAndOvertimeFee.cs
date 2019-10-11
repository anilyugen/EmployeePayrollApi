using EmployeePayrollApi.Library.FeeCalculations;

namespace EmployeePayrollApi.Library.Employees
{
	public class EmployeeWithMonthlyFeeAndOvertimeFee : EmployeeWithMonthlyFee
	{
		public decimal OvertimeHour { get; set; }

		public decimal OvertimeFee { get; set; }

		public EmployeeWithMonthlyFeeAndOvertimeFee()
		{ }

		public EmployeeWithMonthlyFeeAndOvertimeFee(string identityNumber, string name, decimal monthlyFee, decimal overtimeHour, decimal overtimeFee)
			: base(identityNumber, name, monthlyFee)
		{
			this.OvertimeHour = overtimeHour;
			this.OvertimeFee = overtimeFee;
		}

		protected override void AddCalculators()
		{
			base.AddCalculators();
			this.feeCalculationInvoker.AddCalculator(new OvertimeFeeCalculator(this.OvertimeHour, this.OvertimeFee));
		}
	}
}