using System;

namespace ClashOfClans.Core.Units
{
    public class Giant : UnitBase
    {
        public Giant() : base(3000, 4500, "OUR IRON FISTS WILL BE REMEMBERED FOREVER") { }

        public int Move(int seconds)
        {
            MoveBehaviorRepo giant = new MoveBehaviorRepo();
            return giant.Walk(seconds);
        }
    }
}
