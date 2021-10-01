using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    
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

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";

      string title2 = "Pastry";
      string description2 = "Chocolate";
      int price2 = 12;
      string date2 = "2020 May 30";

      Order newOrder1 = new Order(title, description, price, date);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title = "Bread";
      string description = "Wheat";
      int price = 30;
      string date = "2021 April 30";

      string title2 = "Pastry";
      string description2 = "Chocolate";
      int price2 = 12;
      string date2 = "2020 May 30";

      Order newOrder1 = new Order(title, description, price, date);
      Order newOrder2 = new Order(title2, description2, price2, date2);

      //Act
      Item result = Item.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}