using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // Vars
        private ISweepstakesManager _manager;

        // Ctor
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }

        // Dependency Injection (DI) is being used in the MarketingFirm constructor to 
        // assign _manager to whichever Manager class the user chooses from the Simulation
        // class. Since both Manager classes inherit from the ISweepstakesManager interface,
        // methods within the child classes are invoked in the same way (though the logic
        // within those member methods differ in each class). Therefore, by implementing DI
        // following the factory design pattern, this application is much more flexible 
        // than if the "new" keyword would have been used to hardcode which child class of
        // the ISweepstakesManager interface needs to be used on instatiation of a 
        // MarketingFirm() object. NOTE: this is an example of Constructor DI.

        // Methods
        public void CreateSweepstake()
        {
            Console.Write("Give the sweepstake a name: ");
            string sName = Console.ReadLine();
            Sweepstakes newSS = new Sweepstakes(sName);
            _manager.InsertSweepstakes(newSS);
        }
    }
}
