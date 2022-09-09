using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDayAssesment
{
    public abstract class MemberShip
    {
        public abstract void Accommodation();
        public abstract void Food();
    }
    public class Silver : MemberShip
    {
        public override void Accommodation()
        {            
            Console.WriteLine("3 days accommodation at resort");
        }
        public override void Food()
        {
            Console.WriteLine("");
        }
    }
    public class Gold : MemberShip
    {
        public override void Accommodation()
        {            
            Console.WriteLine("5 Days accommodation at resort.");

        }
        public override void Food()
        {
            Console.WriteLine("2 Dinners on the house");

        }
    }
    public class Platinum : MemberShip
    {
        public override void Accommodation()
        {            
            Console.WriteLine("7 Days accommodation at resort.");
        }
        public override void Food()
        {
            Console.WriteLine("5 Dinner on the house");
        }
    }

    internal class MemberShipPackage
    {
        public static void Main()
        {
            Silver silver = new Silver();
            Console.WriteLine("Silver Membership:");
            silver.Accommodation();
            silver.Food();
            Gold gold = new Gold();
            Console.WriteLine("Gold Membership:");
            gold.Accommodation();
            gold.Food();
            Console.WriteLine("");
            Platinum platinum = new Platinum();
            Console.WriteLine("Platinum Membership:");
            platinum.Accommodation();
            platinum.Food();

        }
    }
}