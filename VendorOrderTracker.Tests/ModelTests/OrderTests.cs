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
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitleDescriptionDate_ReturnsTitleDescriptionDate_String_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";
      
      //Act
      Order newOrder = new Order(title, description, price, date);
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      int priceResult = newOrder.Price;
      string dateResult = newOrder.Date;

      //Assert
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }

  }
}