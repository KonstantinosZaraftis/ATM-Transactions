using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenSourceProjects
{
    class BankAccountList
    {
        public DisplayMenu DisplayMenu { get; set; }
        public List<BankAccount> bankAccountList { get; set; }
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
                    myMenu.ProcessMenuOption(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {


                    string spinNumber = Convert.ToString(pinNumber);
                    int pinattemp = 0;
                    while (spinNumber.Length != 4)
                    {
                        Console.WriteLine("Please enter the right pin number.\n");
                        
                            int newpinNumber = Convert.ToInt32(Console.ReadLine());
                        if(newpinNumber== bankAccount.Card.CardPin)
                        {
                            Console.WriteLine("Welcome" + " " + bankAccount.FullName);
                            myMenu.DiplayMenuScreen();
                            myMenu.ProcessMenuOption(Convert.ToInt32(Console.ReadLine()));

                        }
                        pinattemp++;
                        if (pinattemp >= 4)
                        {
                            break;

                            Console.WriteLine("You card has locked. Please call helpcenter\n");
                            Console.WriteLine("Please push the Exit button to take your card.\n");
                        }

                       
                    }


                    Thread.Sleep(5000);
                    Environment.Exit(0);


                }



            }
        }
    }
}
