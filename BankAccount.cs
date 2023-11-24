using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
	class BankAccount
	{
		public string ownerName;
		public decimal balance; 
		public string accountNumber;
		public string accountType;
		public DateTime accountOpeningDate;
		public bool isAccountActive;

		public BankAccount(string name, decimal balance, string accountNumber, string accountType, DateTime accountOpeningDate)
		{
			this.ownerName = name;
			this.balance = balance;
			this.accountNumber = accountNumber;
			this.accountType = accountType;
			this.accountOpeningDate = accountOpeningDate;
			this.isAccountActive = true;
		}
		public void PrintAccountInfo()
		{
			string aktivitas = this.isAccountActive ? "aktiv" : "inaktiv";
			Console.WriteLine($"Az ügyfél neve: {this.ownerName}\nAz ön egyenlege: {this.balance} Ft\nAz ön bankszámlaszáma: {this.accountNumber}\nAz ön számlatipusa: {this.accountType}\nAz ön bankszámlanyitásának dátuma: {this.accountOpeningDate}\nAz ön fiókjának aktivitási státusza: {aktivitas}");
		}
		public void CloseAccount()
		{
			this.isAccountActive = false;
			Console.WriteLine("A bankszámlát zároltuk a kérésére!");
		}
		public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
		{
			if (this.balance >= amount && this.isAccountActive && destinationAccount.isAccountActive)
			{
				this.balance -= amount;
				destinationAccount.balance += amount;
				Console.WriteLine($"Az átutalás sikeresen megtörtént!\nAz elküldött összeg: {amount}Ft");
			}
			else { Console.WriteLine("\nAz ön számláján nincs elég fedezet, vagy zárolták valamelyik számlát.\n"); }
		}
		public void UpdateAccountType(string newAccountType)
		{
			this.accountType = newAccountType;
			Console.WriteLine("A bankszámla tipusa sikeresen megváltoztatva!");
		}
	}
}
