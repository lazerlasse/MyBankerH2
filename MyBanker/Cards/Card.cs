using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
	public abstract class Card
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int CardNumber { get; set; }
		public int AccountNumber { get; set; }

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
