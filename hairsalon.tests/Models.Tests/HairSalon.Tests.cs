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
        [TestMethod]
        public void ClearAll_ClearAllStylistsFromDatabase_0()
        {
            List<Stylist> testList = new List<Stylist>();
            Stylist stylistA = new Stylist("Farron", "Alan");
            Stylist stylistB = new Stylist("Murphy", "Brenda");
            Stylist stylistC = new Stylist("Zamera", "Charlie");
            testList.Add(stylistA);
            testList.Add(stylistB);
            testList.Add(stylistC);
            stylistA.Save();
            stylistB.Save();
            stylistC.Save();

            Stylist.ClearAll();
            List<Stylist> resultList = Stylist.GetAll();

            Assert.AreEqual(false,resultList.Count==0);                
        }

    }
  }
