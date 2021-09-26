using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";
      Order newOrder = new Order(title, description, price);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}