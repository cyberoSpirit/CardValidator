using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardValidator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string clinedNumber = "";
            string cardNumber;

            while (clinedNumber.Length < 12)
            {
                Console.WriteLine("Enter card number:");
                cardNumber = Console.ReadLine();
                clinedNumber = cardNumber.Replace(" ", "");

                if (!clinedNumber.All(char.IsDigit))
                {
                    Console.WriteLine("Card number contain wrong symbols.\nPlease enter card number:");
                    clinedNumber = "";
                }
            }

            Console.WriteLine(CreditCardUtility.GetCreditCardVendor(clinedNumber));

            string isNumberValid = CreditCardUtility.IsCreditCardNumberValid(clinedNumber) ? "valid" : "not valid";
            Console.WriteLine("Card number is " + isNumberValid);

            string nextNumber = CreditCardUtility.GenerateNextCreditCardNumber(clinedNumber);
            Console.WriteLine("Next card number is " + nextNumber);

            isNumberValid = CreditCardUtility.IsCreditCardNumberValid(nextNumber) ? "valid" : "not valid";
            Console.WriteLine("Next card number is " + isNumberValid);

            Console.ReadLine();
        }
    }
}
