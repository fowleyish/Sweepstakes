using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Sweepstakes
{
    class Simulation
    {
        // Vars
        // Ctor
        // Methods
        public void CreateMarketingFirmWithManager()
        {
            Console.Write("Stack or Queue?: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "stack":
                    new MarketingFirm(new SweepstakesStackManager());
                    break;
                case "queue":
                    new MarketingFirm(new SweepstakesQueueManager());
                    break;
                default:
                    Console.WriteLine("That is not a valid option.");
                    CreateMarketingFirmWithManager();
                    break;
            }
        }
    }
}
