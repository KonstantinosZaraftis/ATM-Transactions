using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceProjects
{
    class DisplayMenu
    {

        public BankAccount BankAccount { get; set; }
        public void DiplayMenuScreen()
        {

            Console.WriteLine(" -------------------------------");
            Console.WriteLine(" |     Zara ATM Menu           | ");
            Console.WriteLine(" |                             | ");
            Console.WriteLine(" |   1. AccountBalance         | ");
            Console.WriteLine(" |   2. Cash Deposit           | ");
            Console.WriteLine(" |   3. WithDrawal             | ");
            Console.WriteLine(" |   4. Third Party Transfer   | ");
            Console.WriteLine(" |   5. Transactions           | ");
            Console.WriteLine(" |   6. Logout                 | ");
            Console.WriteLine(" |                             | ");
            Console.WriteLine(" -------------------------------");
            Console.WriteLine("Please select an option\n");


        }

        public void ProcessMenuOption(int option)
        {
            if (option == 1)
            {
                Enum.Menu atmmenu = Enum.Menu.CheckBalance;
                Console.WriteLine(atmmenu);
                //Console.WriteLine("Account Balance is " + "" + bankAccount.AccountBalance);
            }

            if (option == 2)
            {
                Enum.Menu atmmenu = Enum.Menu.PlaceDeposit;
                Console.WriteLine(atmmenu);
                Console.WriteLine("Please enter the amount you want to deposit\n");
                int deposit = Convert.ToInt32(Console.ReadLine());
                int amount = 0;
                amount = amount + deposit;
                // int newAccountBalance = (int)bankAccount.AccountBalance + amount;
                //Console.WriteLine("Your account balance now is " + newAccountBalance);
            }
            if (option == 3)
            {
                Enum.Menu atmmenu = Enum.Menu.MakeWithdrawal;
                Console.WriteLine(atmmenu);
                Console.WriteLine("Please enter the amount you want to withdraw");
                //int withdraw = Convert.ToInt32(Console.ReadLine());
                //if (withdraw > bankAccount.AccountBalance)
                //{
                //    Console.WriteLine("The amount you ask for is not avaliable please try again");
                //}
                //else
                //{
                //    //    int _accountBalance = (int)bankAccount.AccountBalance - withdraw;
                //    //    Console.WriteLine("Your acountBalance now is " + _accountBalance);
                //}


            }

            if (option == 4)
            {
                Enum.Menu atmmenu = Enum.Menu.ThirdPartyTransfer;
                Console.WriteLine(atmmenu);
            }
            if (option == 5)
            {
                Enum.Menu atmmenu = Enum.Menu.ViewTransaction;
                Console.WriteLine(atmmenu);
            }
            if (option == 6)
            {
                Enum.Menu atmmenu = Enum.Menu.Logout;
                Console.WriteLine(atmmenu);
            }
        }
    }

 }
