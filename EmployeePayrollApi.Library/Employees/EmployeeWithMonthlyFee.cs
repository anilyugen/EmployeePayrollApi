﻿using EmployeePayrollApi.Library.FeeCalculations;
using Newtonsoft.Json;

namespace EmployeePayrollApi.Library.Employees
{
	public class EmployeeWithMonthlyFee : Employee
	{
		[JsonIgnore]
		public decimal MonthlyFee { get; set; }

		public EmployeeWithMonthlyFee() { }

		public EmployeeWithMonthlyFee(string identityNumber, string name, decimal monthlyFee) : base(identityNumber, name)
		{
			this.MonthlyFee = monthlyFee;
		}

		protected override void AddCalculators()
		{
			this.feeCalculationInvoker.AddCalculator(new MonthlyFeeCalculator(this.MonthlyFee));
		}
	}
}