using System;
using ClashOfClans.Core.Buildings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClashOfClansTest.Exercise_1
{
    [TestClass]
    public class WhenProducingBlackElixir
    {
        [TestMethod]
        public void And_Gems_Supplied_Are_Not_Enough_Throw_DwarfsAngryException()
        {
            // Arrange
            BlackElixirFactory factory = new BlackElixirFactory();
            int gems = 5;
            int blueElixir = 200;

            // Act
            int result = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void And_BlueElixir_Supplied_Is_Not_Enough_Throw_DwarfsAngryException()
        {
            // Arrange
            BlackElixirFactory factory = new BlackElixirFactory();
            int gems = 5;
            int blueElixir = 200;

            // Act
            int result = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void With_2_Gems_And_500_BlueElixir_Should_Produce_100_BlackElixir()
        {
            // Arrange
            BlackElixirFactory factory = new BlackElixirFactory();
            int gems = 2;
            int blueElixir = 500;

            // Act
            int result = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void With_5_Gems_And_200_BlueElixir_Should_Produce_100_BlackElixir()
        {
            // Arrange
            BlackElixirFactory factory = new BlackElixirFactory();
            int gems = 5;
            int blueElixir = 200;

            // Act
            int result = BlackElixirFactory.ProduceElixir(gems, blueElixir);

            // Assert
            Assert.AreEqual(100, result);
        }
    }
}
