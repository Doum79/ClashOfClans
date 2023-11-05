using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Units
{
    public class MoveBehaviorRepo : IMoveBehavior
    {
        public  int Fly(int seconds)
        {
           return 8;
        }

        public  int TunnelUnder(int seconds)
        {
            return 5;
        }

        public  int Walk(int seconds)
        {
           return 3;
        }
    }
}
