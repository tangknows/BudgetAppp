using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;

namespace BudgetAppp
{
	public class Expense
	{
		public Expense ()
		{
		}

		public string directory { get; set; }
		public string paymentType { get; set; }


		public void GrabExpenses()
		{
			Console.WriteLine("Grabing your expenses now..");
			string dateToday = DateTime.Now.ToString("yyyy-MM-dd+hh:mm"); 

			var reader = new StreamReader(File.OpenRead(directory));
			List <string> listA = new List<string> ();
			while (!reader.EndOfStream) {
				var line = reader.ReadLine ();
				var values = line.Split (',');
				listA.Add (values [1]);
				}
			listA.RemoveAt (0);

			var intList = listA.Select(x => decimal.Parse(x)).ToList();
			decimal total = intList.Sum ();
			Budget.totalExpense.Add (total);

		}




	}
}

