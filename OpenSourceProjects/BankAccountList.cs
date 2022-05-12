
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSourceProjects
{
    class BankAccountList : ITransaction
    {

        public DisplayMenu DisplayMenu { get; set; }

        public List<BankAccount> bankAccountList { get; set; }
        


        public void CheckBalance(decimal accountBalance)
        {
            Console.WriteLine("Your AccountBalance is "+ accountBalance);
        }
        public void MakeDeposit()
        {
            Console.WriteLine("Please enter the amount you want to deposit\n");
            int deposit = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
            amount = amount + deposit;
        }

        public void DataBaseList(int pinNumber)
        {
            bankAccountList = new List<BankAccount>()
            {
                new BankAccount(){BankAccountId=1,AccountNumber=5707044557788,FullName="Konstantinos Zaraftis",AccountBalance=4000,Card=new Card(){CardId=1,CardNumber=379354508162306L,CardPin=2206,ExpirationDate=new DateTime(2020,1,1)}}

            };

            foreach (BankAccount bankAccount in bankAccountList)
            {

                DisplayMenu myMenu = new DisplayMenu();


                Console.WriteLine(bankAccount.Card.isValid(379354508162306L));
                if (pinNumber == bankAccount.Card.CardPin)
                {

                    Console.WriteLine("Welcome" + " " + bankAccount.FullName);

                   myMenu.DiplayMenuScreen();
                   ProcessMenuOption(Convert.ToInt32(Console.ReadLine()));


                }

    
                else
                {


                    string spinNumber = Convert.ToString(pinNumber);
                    int pinattemp = 0;
                    while (spinNumber.Length != 4|| !(pinNumber == bankAccount.Card.CardPin))
                    {
                        Console.WriteLine("Please enter the right pin number.\n");

                        int newpinNumber = Convert.ToInt32(Console.ReadLine());
                        if (newpinNumber == bankAccount.Card.CardPin)
                        {
                            Console.WriteLine("Welcome" + " " + bankAccount.FullName);
                            myMenu.DiplayMenuScreen();
                            ProcessMenuOption(Convert.ToInt32(Console.ReadLine()));

                        }
                        pinattemp++;
                        if (pinattemp == 4)
                        {
                          

                            Console.WriteLine("You card has locked. Please call helpcenter\n");
                            Console.WriteLine("Please push the Exit button to take your card.\n");
                            break;
                        }

                       
                    }

                    Thread.Sleep(5000);
                    Environment.Exit(0);




                }

                void ProcessMenuOption(int option)
                {

                    if (option == 1)
                    {
                        Enum.Menu atmmenu = Enum.Menu.CheckBalance;
                        CheckBalance(bankAccount.AccountBalance);


                    }

                    if (option == 2)
                    {
                        Enum.Menu atmmenu = Enum.Menu.PlaceDeposit;
                        Console.WriteLine(atmmenu);


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
    }
}
