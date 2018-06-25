using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class Userinterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("Please enter contestant's first name.");
            return Console.ReadLine(); 
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter contestant's last name.");
            return Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Please enter contestant's email address.");
            return Console.ReadLine();
        }
    }
}
