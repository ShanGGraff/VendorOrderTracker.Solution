using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }
  
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string vendorName = "Darkstar";
      string vendorDescription = "East location";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    // [TestMethod]
    // public void AddOrder_AssociatesOrderWithCategory_OrderList()
    // {
    //   //Arrange
    //   string title = "Bread";
    //   string description = "Wheat";
    //   int price = 30;
    //   string date = "2021 April 30";
    //   Order newOrder = new Order(title, description, price, date);
    //   List<Vendor> newList = new List<Vendor> { newOrder };

    //   Vendor newVendor = new Vendor();

    //   newVendor.AddOrder(newOrder);

    //   //Act
    //   List<Order> result = newVendor.Order;

    //   //Assert
    //   CollectionAssert.AreEqual(newOrder, result);
    // }

  }
}