using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDayAssesment
{
    public class BaseTax
    {
public void CalculateTax(decimal amount)
        {
            decimal tax = (amount * 20) / 100;
            Console.WriteLine("The 20% tax is: {0}",tax);
        }
    }
    public class DerivedTax : BaseTax
    {
        public new void CalculateTax(decimal amount)
        {
            decimal tax = (amount * 12) / 100;
            Console.WriteLine("The 12% tax is: {0}", tax);
        }
    }

    internal class TaxCalculation
    {
        public static void Main()
        {
            Console.WriteLine("Enter Amount To Calculate Tax");
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            BaseTax baseTax = new BaseTax();
            baseTax.CalculateTax(amt);
            DerivedTax derivedTax = new DerivedTax();
            derivedTax.CalculateTax(amt);
        }
    }
    
}
