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
      Order newOrder = new Order(title, description);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

  }
}