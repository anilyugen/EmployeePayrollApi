using System;

using EmployeePayrollApi.Library.FeeCalculations;

namespace EmployeePayrollApi.Library.Employees
{
	public abstract class Employee
	{
		public Employee()
		{
			this.feeCalculationInvoker = new FeeCalculationInvoker();
		}

		public Employee(string identityNumber, string name)
		{
			this.feeCalculationInvoker = new FeeCalculationInvoker();
			this.IdentityNumber = identityNumber;
			this.Name = name;
		}

		public string IdentityNumber { get; set; }

		public string Name { get; set; }

		public decimal Salary
		{
			get
			{
				return GetSalary();
			}
		}

		protected FeeCalculationInvoker feeCalculationInvoker;

		protected abstract void AddCalculators();

		private decimal GetSalary()
		{
			this.feeCalculationInvoker.Reset();
			AddCalculators();
			return this.feeCalculationInvoker.Calculate();
		}
	}
}