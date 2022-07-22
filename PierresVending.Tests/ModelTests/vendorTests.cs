using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresVending.Models;
using System;

namespace VendorTests.Tests
{
  [TestClass]
  public class VendorTests 
  {

   
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test");
      Assert.AreEqual(typeof(Vendor),newVendor.GetType());
    }

     [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";

      //Act
      Vendor newVendor = new Vendor(description);
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

     [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string description = "Walk the dog.";
      Vendor newVendor = new Vendor(description);

      //Act
      string updatedDescription = "Do the dishes";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
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
  }
}