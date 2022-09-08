using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDayAssesment
{
    internal class LoginValidation
    {
        string email = "divyabharathi@gmail.com", passwrd = "d1234@", mobileNo="+91-123456890";
        int memberId = 123, memberPin = 876, mobilePin = 4567;

        public void Validate(string emailId,string pasaword)
        {
            if(emailId == email && pasaword == passwrd)
            {
                Console.WriteLine("Valid User Login by Email and Password");
            }
            else
            {
                Console.WriteLine("Invalid User Login");
            }
        }
        public void Validate(int memberShipId, int pin)
        {
            if (memberShipId == memberId && pin == memberPin)
            {
                Console.WriteLine("Valid User Login by MemberShipId and Pin");
            }
            else
            {
                Console.WriteLine("Invalid User Login");
            }
        }
        public void Validate(string mobile, int pin)
        {
            if (mobile == mobileNo && pin == mobilePin)
            {
                Console.WriteLine("Valid User Login by Mobile and Pin");
            }
            else
            {
                Console.WriteLine("Invalid User Login");
            }
        }

        public static void Main()
        {
            LoginValidation validation = new LoginValidation();
            validation.Validate("deepa@gmail.com","t456@");
            validation.Validate("divyabharathi@gmail.com", "d1234@");
            validation.Validate(765, 123);
            validation.Validate(123, 876);
            validation.Validate("+91-9876543112", 1230);
            validation.Validate("+91-123456890", 4567);
        }
        
        
            

    }
}
