using EmployeePayrollApi.Library.FeeCalculations;
using Newtonsoft.Json;

namespace EmployeePayrollApi.Library.Employees
{
	public class EmployeeWithDailyFee : Employee
	{
		[JsonIgnore]
		public decimal DailyFee { get; set; }

		[JsonIgnore]
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