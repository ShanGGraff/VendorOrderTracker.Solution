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

    [TestMethod]
    public void GetDescription_ReturnsNameDescription_String()
    {
      //Arrange
      string name = "Darkstar.";
      string description = "We sell the best bread ever";

      //Act
      Vendor newVendor = new Vendor(name, description);
      string nameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;

      //Assert
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      // Arrange
      List<Vendor> newVendor = new List<Vendor> { };

      // Act
      List<Vendor> result = Vendor.GetAll();

      // Assert
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendor_VendorList()
    {
      //Arrange
      string name01 = "Darkstar";
      string description01 = "Emerson St";
      string name02 = "Lightstar";
      string description02 = "Killingsworth";

      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newVendor = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void GetId_VendorInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string name = "Darkstar";
      string description = "Emerson St";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "Darkstar";
      string description01 = "Emerson St";
      string name02 = "Lightstar";
      string description02 = "Killingsworth";

      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Dark Star";
      string vendorDescription = "MLK location";
      Vendor newVendor = new Vendor(name, vendorDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newCategory.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}