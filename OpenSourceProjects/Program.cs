using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
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
            BankAccountList mybankAccountList = new BankAccountList();
            mybankAccountList.DataBaseList(pinNumber);
           
            Console.ReadKey();

        }









    }

   
    
}
