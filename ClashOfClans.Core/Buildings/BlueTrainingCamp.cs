using System;
using ClashOfClans.Core.Units;

namespace ClashOfClans.Core.Buildings
{
    public class BlueTrainingCamp
    {
        public static Bomber ProduceBomber()
        {
            return new Bomber();
        }

        public static Giant ProduceGiant()
        {
            return new Giant();
        }

        public static Miner ProduceMiner()
        {
            return new Miner();
        }
    }
}
