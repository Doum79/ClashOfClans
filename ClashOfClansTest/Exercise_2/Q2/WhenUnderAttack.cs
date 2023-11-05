using System;
using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_2.Q2
{
    [TestClass]
    public class WhenUnderAttack
    {
        [TestMethod]
        public void With_10000_OffensiveHitpoints_Then_A_Dragon_Dies_And_Shouts_His_Last_Message()
        {
            //Act
            var dragonUnit = BlackTrainingCamp.ProduceUnit(UnitType.Dragon);
            dragonUnit.ReceiveHit(2000,out string lastMessageBeforeDying);
            // Assert
            Assert.IsTrue(dragonUnit.DefensiveHitpoints > 0);
            //Assert.IsFalse(!string.IsNullOrEmpty(lastMessageBeforeDying));

            // Act
            //dragonUnit.ReceiveHit(8000, out string lastMessageBeforeDying);
            // Assert
            //Assert.IsTrue(dragonUnit.DefensiveHitpoints <=0);
            Assert.IsTrue(lastMessageBeforeDying == "I WILL RISE AGAIN FROM THE ASHES");
        }
        
        [TestMethod]
        public void With_4501_OffensiveHitpoints_Then_A_Giant_Dies_And_Shouts_His_Last_Message()
        {
            //Act
            var giantUnit = BlueTrainingCamp.ProduceGiant();
          
            giantUnit.ReceiveHit(4501, out string lastMessageBeforeDying);
            //assert
            Assert.IsTrue(giantUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(lastMessageBeforeDying == "OUR IRON FISTS WILL BE REMEMBERED FOREVER");
        }

        [TestMethod]
        public void With_1300_OffensiveHitpoints_Then_A_Miner_Dies_And_Shouts_His_Last_Message()
        {
            //Act
            var minerUnit = BlueTrainingCamp.ProduceMiner();
            minerUnit.ReceiveHit(1300, out string lastMessageBeforeDying);

            //Assert
            //Assert.IsTrue(minerUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(lastMessageBeforeDying.ToLowerInvariant() == "we return in the ground");
        }

        [TestMethod]
        public void With_400_OffensiveHitpoints_Then_A_Bomber_Dies_And_Shouts_His_Last_Message()
        {
            //Act
            var bomberUnit = BlueTrainingCamp.ProduceBomber();
            var expectedMessage = "WHEN YOU play with Explosives is dangerous bussiness";
            
            bomberUnit.ReceiveHit(400, out var lastMessageBeforeDying);

            //Assert
           Assert.IsTrue(bomberUnit.DefensiveHitpoints <= 0);
            Assert.IsTrue(string.Equals(lastMessageBeforeDying, expectedMessage, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
