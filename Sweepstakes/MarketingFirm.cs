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
