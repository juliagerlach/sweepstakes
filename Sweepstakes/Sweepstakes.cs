using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        Random random = new Random();

        //ctr
        public Sweepstakes()
        {
            
            
        }

        public void RegisterContestant()
        {
            //assign random registration mumber
            //enter first name, last name, email address
            //increase registration number
            Console.WriteLine("To register a new sweepstakes contestant, type 'new' and then press 'enter'. To go back to the main menu, type 'exit'.");
            string input = Console.ReadLine();

            if (input == "new")
            {
                Contestant contestant = new Contestant();
                
                Console.WriteLine("Please enter contestant's first name.");
                contestant.FirstName = Console.ReadLine();
                Console.WriteLine("Please enter contestant's last name.");
                contestant.LastName = Console.ReadLine();
                Console.WriteLine("Please enter contestant's email address.");
                contestant.EmailAddress = Console.ReadLine();
                
                contestants.Add(1234, new Contestant());
            }

            else
            {

            }
            

            
        }

        public string PickWinner()
        {
            return "";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }


        

        //Member methods
    }
}
