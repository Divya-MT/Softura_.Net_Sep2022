using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDayAssesment
{

   public abstract class Arithmetic
        {
        public abstract void Add();
        public abstract void Sub();
        public abstract void Mul();
        public abstract void Div();

        }
    public class Calculator : Arithmetic
    {
        public override void Add()
        {
            Console.WriteLine("Enter two numbers to add");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of given {0},{1} is : {2}",n1,n2,n1+n2);
        }
        public override void Sub()
        {
            Console.WriteLine("Enter two numbers to sub");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("differnce of given {0},{1} is : {2}", n1, n2, n1 - n2);
        }
        public override void Mul()
        {
            Console.WriteLine("Enter two numbers to Mul");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("product of given {0},{1} is : {2}", n1, n2, n1 * n2);
        }
        public override void Div()
        {
            Console.WriteLine("Enter two numbers to div");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("division of given {0},{1} is : {2}", n1, n2, n1 / n2);
        }

    }

    internal class ArithmeticOprations
    {
        public static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.Add();
            calculator.Sub();
            calculator.Mul();
            calculator.Div();
             
        }
        


    }
}
