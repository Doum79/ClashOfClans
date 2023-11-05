using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashOfClans.Core.Units
{
    public interface IMoveBehavior
    {
        int Walk(int seconds);
        int Fly(int seconds);
        int TunnelUnder(int seconds);
    }
}
