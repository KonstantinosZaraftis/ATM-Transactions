using System;
using System.Collections.Generic;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace OpenSourceProjects
{
    class Program
    {
        

        static void Main(string[] args)
        {
        Console.Title = "Zara ATM System.";
        Console.WriteLine("Welcome to Zara ATM. \n");
        Console.WriteLine("Please insert your ATM card.\n");


           
            Console.WriteLine("Please Enter your pin number\n");
            int pinNumber = Convert.ToInt32(Console.ReadLine());
            string spinNumber = Convert.ToString(pinNumber);
            List<BankAccount> bankAccountsList = new List<BankAccount>()
            {
                new BankAccount(){BankAccountId=1,AccountNumber=5707044557788,FullName="Konstantinos Zaraftis",AccountBalance=4000,Card=new Card(){CardId=1,CardNumber=379354508162306L,CardPin=2206,ExpirationDate=new DateTime(2020,1,1)}}
                
            };
            
            foreach (BankAccount bankAccount in bankAccountsList)
            {
                 Console.WriteLine(bankAccount.Card.isValid(379354508162306L));
                if (pinNumber ==bankAccount.Card.CardPin)
                {

                    Console.WriteLine("Welcome" + " " + bankAccount.FullName); 
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

                    


                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        Enum.Menu atmmenu = Enum.Menu.CheckBalance;
                        Console.WriteLine(atmmenu);
                        Console.WriteLine("Account Balance is " + "" + bankAccount.AccountBalance);
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
                else
                {

                    int pinattemp = 0;
                    while (spinNumber.Length != 4)
                    {
                        Console.WriteLine("Please enter the right pin number.\n");
                        int newpinNumber = Convert.ToInt32(Console.ReadLine());
                        pinattemp++;
                        if (pinattemp >= 4)
                        {
                            break;


                        }


                    }
                    Console.WriteLine("You card has locked. Please call helpcenter\n");
                    Console.WriteLine("Please push the Exit button to take your card.\n");

                    Thread.Sleep(5000);
                    Environment.Exit(0);




                }


            }
   

            Console.ReadKey();
        }

      
      
   }
}
