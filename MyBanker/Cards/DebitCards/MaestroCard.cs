using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
	class MaestroCard : DebitCard
	{
		public DateTime ExpireDate { get; private set; }

		public MaestroCard(int age, string firstName, string lastName, string cardNumber, string accountNumber, DateTime expireDate)
			: base(age, firstName, lastName, cardNumber, accountNumber)
		{
			ExpireDate = expireDate;
		}
	}
}
