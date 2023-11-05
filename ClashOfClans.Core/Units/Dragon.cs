using System;

namespace ClashOfClans.Core.Units
{
    public class Dragon : UnitBase
    {
        public Dragon() : base(7500, 5000, "I WILL RISE AGAIN FROM THE ASHES") { }
        public int Move(int seconds)
        {
            MoveBehaviorRepo dragon = new MoveBehaviorRepo();
            return dragon.Fly(seconds);
        }
    }
}
