using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
  
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string vendorName = "Darkstar";
      string vendorDescription = "East location";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithCategory_OrderList()
    {
      
    }

  }
}