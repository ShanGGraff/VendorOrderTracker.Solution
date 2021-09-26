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
      Vendor newVendor = new Vendor(vendorName);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

  
  }
}