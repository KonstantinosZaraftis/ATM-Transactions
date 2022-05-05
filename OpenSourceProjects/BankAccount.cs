using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceProjects
{
    class BankAccount
    {
        public int BankAccountId { get; set; }
        public long AccountNumber { get; set; }
        public string FullName { get; set; }

        public decimal AccountBalance = 0;
        public Card Card { get; set; }

        public BankAccountList BankAccountList { get; set; }






    }
}
