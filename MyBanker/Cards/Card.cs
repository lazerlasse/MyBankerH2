using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
	public abstract class Card
	{
		public string FirstName { get; private set; }
		public string LastName { get; private set; }
		public string CardNumber { get; private set; }
		public string AccountNumber { get; private set; }


		public Card(string firstName, string lastName, string cardNumber, string accountNumber)
		{
			FirstName = firstName;
			LastName = lastName;
			CardNumber = cardNumber;
			AccountNumber = accountNumber;
		}


		public override string ToString()
		{
			return "Fornavn: "
				+ FirstName
				+ "Efternavn: "
				+ LastName
				+ "\nKort nr. "
				+ CardNumber
				+ "Konto nr. "
				+ AccountNumber; 
		}
	}
}
