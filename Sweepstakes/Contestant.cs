using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string EmailAddress
        {
            get => emailAddress;
            set => emailAddress = value;
        }

        public int RegistrationNumber
        {
            get => registrationNumber;
            set => registrationNumber = value;
        }


        //ctr

        //Member methods
    }
}
