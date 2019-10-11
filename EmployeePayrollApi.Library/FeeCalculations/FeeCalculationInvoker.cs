using System.Collections.Generic;

namespace EmployeePayrollApi.Library.FeeCalculations
{
	public class FeeCalculationInvoker
	{
		private IList<IFeeCalculator> Calculators { get; set; }

		public FeeCalculationInvoker()
		{
			this.Calculators = new List<IFeeCalculator>();
		}

		public void AddCalculator(IFeeCalculator calculator)
		{
			this.Calculators.Add(calculator);
		}

		public void Reset()
		{
			this.Calculators.Clear();
		}

		public decimal Calculate()
		{
			decimal totalFee = 0;

			for (int i = 0; i < this.Calculators.Count; i++)
			{
				totalFee += this.Calculators[i].Calculate();
			}

			return totalFee;
		}
	}
}