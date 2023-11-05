using System;

namespace ClashOfClans.Core.Units
{
    public class Bomber : UnitBase
    {
        public Bomber() : base(800, 350, "WHEN YOU play with Explosives is dangerous bussiness") { }

        public int Move(int seconds)
        {
            MoveBehaviorRepo bomber = new MoveBehaviorRepo();
            return bomber.Walk(seconds);
        }
    }
}
