using EmployeePayrollApi.Library.FeeCalculations;

namespace EmployeePayrollApi.Library.Employees
{
	public class EmployeeWithDailyFee : Employee
	{
		public decimal DailyFee { get; set; }

		public decimal WorkingDayCount { get; set; }

		public EmployeeWithDailyFee() { }

		public EmployeeWithDailyFee(string identityNumber, string name, decimal dailyFee, decimal workingDayCount) : base(identityNumber, name)
		{
			this.DailyFee = dailyFee;
			this.WorkingDayCount = workingDayCount;
		}

		protected override void AddCalculators()
		{
			this.feeCalculationInvoker.AddCalculator(new DailyFeeCalculator(this.DailyFee, this.WorkingDayCount));
		}
	}
}