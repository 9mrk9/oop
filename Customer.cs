using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
	public class Customer
	{
		public string customerName;
		public int customerAge;
		public string customerAddress;
		public string customerEmail;
		public string customerPhoneNumber;
		public List<string> customerSupport;
		public List<string> customerFeedBack;

		public Customer(string name, int age, string address, string email, string phone)
		{
			this.customerName = name;
			this.customerAge = age;
			this.customerAddress = address;
			this.customerEmail = email;
			this.customerPhoneNumber = phone;
			this.customerSupport = new List<string>();
			this.customerFeedBack = new List<string>();
		}

		public void PrintCustomerInfo()
		{
			Console.WriteLine($"Név: {this.customerName}\nÉletkor: {this.customerAge}\nCím: {this.customerAddress}\nEmail: {this.customerEmail}\nTelefonszám: {this.customerPhoneNumber}");
		}

		public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhoneNumber)
		{
			this.customerName = newName;
			this.customerAge = newAge;
			this.customerAddress = newAddress;
			this.customerEmail = newEmail;
			this.customerPhoneNumber = newPhoneNumber;
		}

		public void PlaceOrder(string product, int quantity) {
			Console.WriteLine($"{quantity}db {product}-t rendelt az adott személy!");
		}

		public void RequestSupport(string supportRequest)
		{
			this.customerSupport.Add(supportRequest);
			Console.WriteLine("A támogatási kérelme sikeresen végbement! (support request)");
		}

		public void SendFeedback(string feedback)
		{
			this.customerFeedBack.Add(feedback);
			Console.WriteLine("Sikeresen elküldte a visszajelzését! (feedback)");
		}
	}
}
