using ClashOfClans.Core.Buildings;
using ClashOfClans.Core.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_2.Q1
{
    [TestClass]
    public class WhenBlueTrainingCampProduces
    {
        [TestMethod]
        public void A_Bomber_Then_It_Should_Have_800_OffensiveHitpoints()
        {
            // Act
            var newlyCreatedBomber = BlueTrainingCamp.ProduceBomber();

            // Assert
            Assert.AreEqual(800, newlyCreatedBomber.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Bomber_Then_It_Should_Have_350_DefensiveHitpoints()
        {
            // Act
            var newlyCreatedBomber = BlueTrainingCamp.ProduceBomber();

            // Assert
            Assert.AreEqual(350, newlyCreatedBomber.DefensiveHitpoints);
        }

        [TestMethod]
        public void A_Giant_Then_It_Should_Have_3000_OffensiveHitpoints()
        {
            // Act
            var newlyCreatedGiant = BlueTrainingCamp.ProduceGiant();

            // Assert
            Assert.AreEqual(3000, newlyCreatedGiant.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Giant_Then_It_Should_Have_4500_DefensiveHitpoints()
        {
            // Act
            var newlyCreatedGiant = BlueTrainingCamp.ProduceGiant();

            // Assert
            Assert.AreEqual(4500, newlyCreatedGiant.DefensiveHitpoints);
        }

        [TestMethod]
        public void A_Miner_Then_It_Should_Have_1200_OffensiveHitpoints()
        {
            // Act
            var newlyCreatedMiner = BlueTrainingCamp.ProduceMiner();

            // Assert
            Assert.AreEqual(1200, newlyCreatedMiner.OffensiveHitpoints);
        }

        [TestMethod]
        public void A_Miner_Then_It_Should_Have_800_DefensiveHitpoints()
        {
            // Act
            var newlyCreatedMiner = BlueTrainingCamp.ProduceMiner();

            // Assert
            Assert.AreEqual(800, newlyCreatedMiner.DefensiveHitpoints);
        }
    }
}
