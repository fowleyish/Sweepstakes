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
        public MarketingFirm CreateMarketingFirmWithManager()
        {
            // user input to complete implementation of Factory design method
            Console.Write("Stack or Queue?: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "stack":
                    return new MarketingFirm(new SweepstakesStackManager());
                case "queue":
                    return new MarketingFirm(new SweepstakesQueueManager());
                default:
                    Console.WriteLine("That is not a valid option.");
                    return CreateMarketingFirmWithManager();
            }
        }
    }
}
