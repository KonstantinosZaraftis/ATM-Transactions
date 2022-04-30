using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceProjects.Enum
{
    public enum Menu
    {
        [Description("Check balance")]
        CheckBalance = 1,

        [Description("Place Deposit")]
        PlaceDeposit = 2,

        [Description("Make Withdrawal")]
        MakeWithdrawal = 3,

        [Description("Third Party Transfer")]
        ThirdPartyTransfer = 4,

        [Description("Transaction")]
        ViewTransaction = 5,

        [Description("Logout")]
        Logout = 6


    }
}
