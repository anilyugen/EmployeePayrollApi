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
				this.feeCalculationInvoker.Reset();
				AddCalculators();
				return this.feeCalculationInvoker.Calculate();
			}
		}

		protected FeeCalculationInvoker feeCalculationInvoker;

		protected abstract void AddCalculators();

		public void Print()
		{
			Console.WriteLine("Ad: {0} / Maaş: {1}", this.Name, this.Salary);
		}
	}
}