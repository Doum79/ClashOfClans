using System;

namespace ClashOfClans.Core.Units
{
    public class Miner : UnitBase
    {
        public Miner() : base(1200, 800,  "we return in the ground") { }

        public int Move(int seconds)
        {
            MoveBehaviorRepo mine = new MoveBehaviorRepo();
            return mine.TunnelUnder(seconds);
        }
    }
}
