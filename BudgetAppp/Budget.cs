using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace BudgetAppp
{
	public class Budget
	{
		public Budget ()
		{
		}

		public static List <decimal> totalExpense = new List <decimal> (); 
		public static decimal totalSalary;

		decimal totalexpense;


		public Expense createExpense (string csvFileDirectory, string paymentType){

			Expense e = new Expense ();

			e.paymentType = paymentType;
			e.directory = csvFileDirectory;

			return e;
	
		}
			
		public FinancialInformation calculateFinance() {

			FinancialInformation financialInformation = new FinancialInformation ();

			foreach (decimal expense in totalExpense) {
				totalexpense = expense + totalexpense;
			}

			financialInformation.ExpenseTotal = totalexpense;
	

			financialInformation.SalaryTotal = totalSalary;


			financialInformation.NetIncome = totalSalary - totalexpense;

			return financialInformation;
	


		}

	}
}

