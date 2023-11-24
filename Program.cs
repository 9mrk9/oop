using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
	internal class Program
	{
		static void Main(string[] args)
		{	
			//Vásárló létrehozása:
			Customer jozsi = new Customer("József", 41, "Isaszegi út 38", "JozseFA@gmail.com", "36209117155");
			//Vásárlóval használható functionök tesztelése:
			Console.WriteLine("A vásárló adatai:\n");
			jozsi.PrintCustomerInfo();
			jozsi.UpdateCustomerInfo("József", 42, "Hungária Krt. 28", "JozseFA@gmail.com", "36201234567");
			Console.WriteLine("\nA vásárló adatai a változtatások után:\n");
			jozsi.PrintCustomerInfo();
			Console.WriteLine("\nÖsszegzés a vásárlásról:");
			jozsi.PlaceOrder("alma", 3);
			Console.WriteLine("\nA hibaüzenet elküldése a supportnak:");
			jozsi.RequestSupport("Promlémám akadt a vásárlás folyamán.\n Kérem mihamarabbi segitségüket!");
			Console.WriteLine("\nA visszajelzés elküldése:");
			jozsi.SendFeedback("Köszönöm szépen a gyors és készséges segitséget!");
			Console.WriteLine("\n\n\n\n\n");
			//Fiókok létrehozása:
			BankAccount jozsiAccount = new BankAccount("József", 1000000, "0000-6101-3242-3077-5487", "folyószámla", new DateTime(2012, 08, 31));
			BankAccount feriAccount = new BankAccount("Ferenc", 3000, "0000-6101-3242-3077-5488", "folyószámla", new DateTime(2020, 09, 14));
			//Fiókokkal használható functionök tesztelése:
			Console.WriteLine("A létező fiókok a banknál:\n");
			jozsiAccount.PrintAccountInfo();
			Console.WriteLine();
			feriAccount.PrintAccountInfo();
			Console.WriteLine("\nÁtutalás:");
			jozsiAccount.TransferFundsTo(feriAccount,20000);
			Console.WriteLine("\nÁtutalás után a fiókok adatai:\n");
			jozsiAccount.PrintAccountInfo();
			Console.WriteLine();
			feriAccount.PrintAccountInfo();
			jozsiAccount.PrintAccountInfo();
			Console.WriteLine("\nFiók zárolás:");
			jozsiAccount.CloseAccount();
			Console.WriteLine("\nFiók információja zárolás után:\n");
			jozsiAccount.PrintAccountInfo();
			Console.ReadKey();
		}
	}
}
