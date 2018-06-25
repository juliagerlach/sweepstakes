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

        public Contestant CreateContestant()
        {
            string firstName = Userinterface.GetFirstName();
            string lastName = Userinterface.GetLastName();
            string emailAddress = Userinterface.GetEmailAddress();

            Contestant contestant = new Contestant(firstName, lastName, emailAddress);
            return contestant;
        }
        public void RegisterContestant(Contestant contestant)
        {
            



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
