using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
	class DebitCard : Card, ICardAge
	{
		public int Age { get; set; }
	}
}
