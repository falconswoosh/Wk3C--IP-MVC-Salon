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
          Stylist.ClearAll();
        }
        [TestMethod]
        public void Save_SaveStylist_0()
        {
            List<Stylist> testStylist = new List<Stylist>();
            Stylist stylistA = new Stylist("test-lastname","test-firstname");
            testStylist.Add(stylistA);
            stylistA.Save();

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

            Assert.AreEqual(true,resultList.Count==0);
        }
        [TestMethod]
        public void GetAll_GetAllSylistsFromDatabase_0()
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

            List<Stylist> resultList = Stylist.GetAll();

            Assert.AreEqual(true,resultList.Count==3);
        }
        [TestMethod]
        public void Find_FindAStylistInDatabase_0()
        {
            Stylist testStylist = new Stylist("Richardson", "Bethany");
            testStylist.Save();

            Stylist foundStylist = Stylist.Find(1);

            Assert.AreEqual(testStylist, foundStylist);
        }
        [TestMethod]
        public void Delete_DeleteStylistFromDatabase_0()
        {
            Stylist testStylist = new Stylist("Richardson", "Bethany");
            testStylist.Save();
            int newID = testStylist.Id;
            int numOfStylists = Stylist.GetAll().Count;
            Stylist.Delete(newID);

            Assert.AreEqual(true, Stylist.GetAll().Count == numOfStylists);
        }
        [TestMethod]
        public void Update_UpdateAStylistInDatabase_0()
        {
            Stylist testStylist = new Stylist("Richardson", "Bethany");
            testStylist.Save();

            string newLastName = "Coruso";
            string newFirstName = "Eliza";

            Stylist newStylist = new Stylist(newLastName, newFirstName);
            newStylist.Update(newLastName, newFirstName);

            Assert.AreNotEqual(testStylist.LastName, newStylist.LastName);
            Assert.AreNotEqual(testStylist.FirstName, newStylist.FirstName);
        }
    }
  }
