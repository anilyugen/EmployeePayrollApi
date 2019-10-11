using System.Collections.Generic;
using EmployeePayrollApi.Library.Employees;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePayrollApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PayrollController : ControllerBase
	{
		// GET api/payroll
		[HttpGet]
		public ActionResult<IEnumerable<Employee>> Get()
		{
			List<Employee> employees = new List<Employee>();
			employees.Add(new EmployeeWithMonthlyFee("1234567", "Anıl Yügen", 4000));
			employees.Add(new EmployeeWithDailyFee("2234567", "Hasan Yılmaz", 200, 22));
			employees.Add(new EmployeeWithMonthlyFeeAndOvertimeFee("3234567", "Seçil Öztufan", 3500, 10, 80));
			return employees;
		}
	}
}