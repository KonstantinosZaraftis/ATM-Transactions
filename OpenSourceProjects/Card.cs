using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceProjects
{
    class Card
    {
        public int CardId { get; set; }
        public long CardNumber { get; set; }
        public int CardPin { get; set; }
        public DateTime ExpirationDate { get; set; }

         
        public bool isValid(long cardNumber)
        {
            return (getSize(cardNumber) >= 13 &&
                    getSize(cardNumber) <= 16) &&
                    (prefixMatched(cardNumber, 4) ||
                    prefixMatched(cardNumber, 5) ||
                    prefixMatched(cardNumber, 37) ||
                    prefixMatched(cardNumber, 6)) &&
                    ((sumOfDoubleEvenPlace(cardNumber) +
                    sumOfOddPlace(cardNumber)) % 10 == 0);
        }

        
        public  int sumOfDoubleEvenPlace(long cardNumber)
        {
            int sum = 0;
            String num = cardNumber + "";
            for (int i = getSize(cardNumber) - 2; i >= 0; i -= 2)
                sum += getDigit(int.Parse(num[i] + "") * 2);

            return sum;
        }

       
        public  int getDigit(int cardNumber)
        {
            if (cardNumber < 9)
                return cardNumber;
            return cardNumber / 10 + cardNumber % 10;
        }


        public  int sumOfOddPlace(long cardNumber)
        {
            int sum = 0;
            String num = cardNumber + "";
            for (int i = getSize(cardNumber) - 1; i >= 0; i -= 2)
                sum += int.Parse(num[i] + "");
            return sum;
        }

       
        public  bool prefixMatched(long cardNumber, int d)
        {
            return getPrefix(cardNumber, getSize(d)) == d;
        }

        
        public  int getSize(long d)
        {
            String num = d + "";
            return num.Length;
        }


        public  long getPrefix(long cardNumber, int k)
        {
            if (getSize(cardNumber) > k)
            {
                String num = cardNumber + "";
                return long.Parse(num.Substring(0, k));
            }
            return cardNumber;
        }
    }


}


