using System;

namespace LabCode
{
    class Interest
    {
        private static void Main(string[] args)
        {
            int year;
            double principleAmount, rate, interest, totalAmount;
            Console.WriteLine("Enter the loan amount");
            principleAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Number of Years");
            year = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the Rate Of Interest");
            rate = Convert.ToDouble(Console.ReadLine());
            interest = principleAmount * year * rate / 100;
            totalAmount = principleAmount + interest;
            Console.WriteLine("Total Amount : {0}", totalAmount);
            Console.ReadLine();
        }
    }
}
