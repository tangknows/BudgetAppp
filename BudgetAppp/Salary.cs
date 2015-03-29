using System;

namespace BudgetAppp
{
	public class Salary
	{
		public Salary ()
		{


		}

		public decimal salaryAmount {get;set;}

		public void GrabSalary () {
			Budget.totalSalary = salaryAmount;
		}

	}
}

