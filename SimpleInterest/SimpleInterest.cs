using System;

namespace SimpleInterest
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            int year;
            double principleAmount, rate, interest, totalAmount;

            Console.WriteLine("Enter the loan amount : ");
            principleAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years : ");
            year = Convert.ToInt16(Console.ReadLine());

            interest = principleAmount * year * rate / 100;

            totalAmount = principleAmount + interest;

            Console.WriteLine("Total Amount : {0}", totalAmount);
        }
    }
}
