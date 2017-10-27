using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Salon.Models;

namespace Salon.Models.Tests
{
  [TestClass]
  public class StylistTests : IDisposable
  {
    public StylistTests()
    {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=salon_test;";
    }
    // public void Dispose()
    // {
    //   Class.ClearAll
    // }
    [TestMethod]
    public void Equals_OverrideTrueForSameDescription_sLastName()
    {
      Stylist FirstStylistLName = new Stylist("Susan", 1);
      Stylist SecondStylistLName = new Stylist("Susan", 1);

      Assert.AreEqual(FirstStylistLName, SecondStylistLName);
    }
    // [TestMethod]
    // public void Method_Description_ExpectedValue()
    // {
    //   Assert.AreEqual(var1, method(input));
    // }
  }
}
