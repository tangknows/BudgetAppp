using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;


namespace BudgetAppp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		
			//Test 
			//Set a budget
			Budget exampleBudget = new Budget ();

			//Add an expense by directing budget.computeTotalExpenses() method to payment type and directory
			Expense exampleCreditCardExpenses = exampleBudget.createExpense(@"/Users/thanhngo/documents/ImportReaderTest/test.csv", "Credit Card");

			//Run the expense's method to grab the data from the excel sheet 
			exampleCreditCardExpenses.GrabExpenses();


			//Add another expense by directing budget.computeTotalExpenses() method to payment type and directory
			Expense exampleSecondCreditCardExpenses = exampleBudget.createExpense(@"/Users/thanhngo/documents/ImportReaderTest/test.csv", "Credit Card");

			//Run the expense's method to grab the data from the excel sheet 
			exampleSecondCreditCardExpenses.GrabExpenses();
		

			//Set the Salary
			Salary exampleSalary = new Salary ();
			exampleSalary.salaryAmount = 1000;
			exampleSalary.GrabSalary ();

			//Run the budget's method to calculate financial information
			FinancialInformation TomsFinancialInformation = exampleBudget.calculateFinance ();


			//Writes your results
			Console.WriteLine (TomsFinancialInformation.ExpenseTotal);
			Console.WriteLine (TomsFinancialInformation.SalaryTotal);
			Console.WriteLine (TomsFinancialInformation.NetIncome);

		}
	}
}
