using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Models.Tests
{
    [TestClass]
    public class StylistTests : IDisposable
    {
        public StylistTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=alan_falcon_test;";
        }
        public void Dispose()
        {
        //   Class.ClearAll
        }
        [TestMethod]
        public void Save_SaveStylist_0()
        {
            //Arrange
            Stylist testStylist = new Stylist("test-lastname","test-firstname");
            //Act
            testStylist.Save();

            Assert.AreEqual(true,Stylist.GetAll().Count==1);
        }
        // [TestMethod]
        // public void GetAll_GetAllStylists_0()

    }
  }
