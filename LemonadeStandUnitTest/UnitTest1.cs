using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
namespace LemonadeStandUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestGenerateRandomWeather()
        //{
        //    Random random = new Random();
        //    Weather weather = new Weather();
        //    //Arrange
        //    string[] weather1 = { "Sunny, High 80's. Perfect day for business!" };
        //    string[] weather2 = { "Cloud with a chance of meatballs. :(" };
        //    string[] weather3 = { "High 80's, Abundant Sunshine." };
        //    //Act
        //    weather.GenerateRandomWeather();
        //    //Assert

        //}

        //[TestMethod]

        //public void TestGeneratePredictedWeather()
        //{
        //    Random random = new Random();
        //    Weather weather = new Weather();
        //    //Arrange
        //    string[] weather4 = { "Sunny, Expected wind chills in the evening." };
        //    string[] weather5 = { "70 degrees, Possibility for a little afternoon rain." };
        //    string[] weather6 = { "Low 70's, Humid." };
        //    //Act
        //    weather.GeneratePredictedWeather();
        //    //Assert
        //}
    
        [TestMethod]
        public void TestLemonInventoryAmount()
        {
            Player player = new Player();
            //Arrange 
            player.lemonCount = 3;
            //Act
            player.BuyLemons();
            //Assert
            Assert.AreEqual(player.lemonCount, player.inventory.lemons.Count);
        }

        [TestMethod]

        public void TestSugarInventoryAmount()
        {
            Player player = new Player();
            //Arrange
            player.sugarCount = 5;
            //Act
            player.BuySugar();
            //Assert
            Assert.AreEqual(player.sugarCount, player.inventory.sugars.Count);
        }

        [TestMethod]

        public void TestIceInventoryAmount()
        {
            Player player = new Player();
            //Arrange
            player.iceCount = 6;
            //Act
            player.BuyIce();
            //Assert
            Assert.AreEqual(player.iceCount, player.inventory.ices.Count);
        }

        [TestMethod]

        public void TestCupInventoryAmount()
        {
            Player player = new Player();
            //Arrange
            player.cupCount = 10;
            //Act
            player.BuyCups();
            //Assert
            Assert.AreEqual(player.cupCount, player.inventory.cups.Count);
        }

        [TestMethod]

        public void TestRemoveLemonInventoryAmount()
        {
            Player player = new Player();
            Lemon lemon = new Lemon();
            //Arrange
            player.inventory.lemons.Add(lemon);
            player.inventory.lemons.Add(lemon);
            player.removeLemonCount = 1;
            //Act
            player.RemoveLemons();
            //Assert
            Assert.AreEqual(1, player.inventory.lemons.Count);
            
        }
       
        [TestMethod]

        public void TestRemoveSugarInventoryAmount()
        {
            Player player = new Player();
            Sugar sugar = new Sugar();
            //Arrange
            player.inventory.sugars.Add(sugar);
            player.inventory.sugars.Add(sugar);
            player.inventory.sugars.Add(sugar);
            player.removeSugarCount = 2;
            //Act
            player.RemoveSugar();
            //Assert
            Assert.AreEqual(1, player.inventory.sugars.Count);
        }

        [TestMethod]

        public void TestRemoveIceInventoryAmount()
        {
            Player player = new Player();
            Ice ice = new Ice();
            //Arrange
            player.inventory.ices.Add(ice);
            player.inventory.ices.Add(ice);
            player.inventory.ices.Add(ice);
            player.removeIceCount = 1;
            //Act
            player.RemoveIce();
            //Assert
            Assert.AreEqual(2, player.inventory.ices.Count);
        }
    }

}
