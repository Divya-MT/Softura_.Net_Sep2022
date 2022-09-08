using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDayAssesment
{
    public class AddSubtract
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Sum of given numbers is {0}", a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Difference of given numbers is {0}", a - b);
        }

    }
    public class MultiplyDivide:AddSubtract
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Product of given numbers is {0}", a * b);
        }
        public void Divide(int a, int b)
        {
            Console.WriteLine("Division of given numbers is {0}", a / b);
        }
    }

    public class ArithmeticOperations
    {
        public static void Main()
        {

            AddSubtract addSubtract = new AddSubtract();
            addSubtract.Add(1, 2);
            addSubtract.Sub(2, 3);
            MultiplyDivide muldiv = new MultiplyDivide();
            muldiv.Multiply(7, 8);
            muldiv.Divide(9, 3);
        }
    }
}

