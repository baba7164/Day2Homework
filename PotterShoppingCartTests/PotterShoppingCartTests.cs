using Microsoft.VisualStudio.TestTools.UnitTesting;
using HarryPotterShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HarryPotterShoppingCart.Tests
{
    [TestClass()]
    public class PotterShoppingCartTests
    {
        [TestMethod]
        public void BuyOneBook100()
        {
            //arrange
            var target = new PotterShoppingCart();
            var book = new HarryPotter
            {
                Count = 1,
                Prize = 100,
            };

            //act
            target.Calculate(book);

            //assert
            var expected = 100;
            Assert.AreEqual(expected, book.Total);
        }
    }
}