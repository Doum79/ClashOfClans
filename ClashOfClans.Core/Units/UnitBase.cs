using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Units
{
    public abstract class UnitBase
    {
        public int OffensiveHitpoints { get; protected set; }
       public int DefensiveHitpoints { get; protected set; }
     public  string LastMessageBeforeDying { get; protected set; }

        protected UnitBase(int offensiveHitpoints, int defensiveHitpoints, string lastMessageBeforeDying)
        {
            OffensiveHitpoints = offensiveHitpoints;
            DefensiveHitpoints = defensiveHitpoints;
            LastMessageBeforeDying = lastMessageBeforeDying;
        }

        public void ReceiveHit(int attackHitpoints, out string lastMessageBeforeDying)
        {
            DefensiveHitpoints -= attackHitpoints;
            if (DefensiveHitpoints <= 0)
            {
                DefensiveHitpoints = 0;

            }
            lastMessageBeforeDying = LastMessageBeforeDying;

        }


    }
}
