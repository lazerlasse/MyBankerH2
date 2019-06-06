using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Cards
{
	class VisaElectron : DebitCard
	{
		public double MonthlyLimit { get; private set; }
		public double CurrentMonthlyUse { get; set; }
		public DateTime ExpireDate { get; set; }
	}
}
