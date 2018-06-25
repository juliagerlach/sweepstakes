using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Program
    {
        static void Main(string[] args)
        {
            SweepstakesStackManager stackManager = new SweepstakesStackManager();
            SweepstakesQueueManager queueManager = new SweepstakesQueueManager();

            Sweepstakes sweepstakes = new Sweepstakes("Packers Ticket Giveaway");
            queueManager.InsertSweepstakes(sweepstakes);
            stackManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("Please enter at least two contestants for the " + sweepstakes.sweepstakesName + ".");
            Console.ReadLine();
            Contestant contestant = sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);

            sweepstakes = new Sweepstakes("Brewers Ticket Giveaway");
            queueManager.InsertSweepstakes(sweepstakes);
            stackManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("Please enter at least two contestants for the " + sweepstakes.sweepstakesName + ".");
            Console.ReadLine();
            sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);


            sweepstakes = new Sweepstakes("Bucks Ticket Giveaway");
            queueManager.InsertSweepstakes(sweepstakes);
            stackManager.InsertSweepstakes(sweepstakes);
            Console.WriteLine("Please enter at least two contestants for the " + sweepstakes.sweepstakesName + ".");
            Console.ReadLine();
            sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);
            sweepstakes.CreateContestant();
            sweepstakes.RegisterContestant(contestant);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(sweepstakes.sweepstakesName);
                Console.WriteLine("Queue Manager:");
                RunSweepstakes(queueManager);
                Console.WriteLine("Stack Manager:");
                RunSweepstakes(stackManager);
                Console.WriteLine();
            }
            Console.ReadLine();
        }

            private static void RunSweepstakes(ISweepstakesManager sweepstakesManager)
            {
                Sweepstakes sweepstakes = sweepstakesManager.GetSweepstakes();
                Console.WriteLine($"The winner of {sweepstakes.sweepstakesName} is...");

                string winner = sweepstakes.PickWinner();
                Console.WriteLine(winner);
                Console.ReadLine();
            }
        
    }
}
