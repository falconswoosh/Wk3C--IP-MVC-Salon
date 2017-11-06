using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HairSalon.Models;

namespace HairSalon.Models.Tests
{
    [TestClass]
    public class ClientTests : IDisposable
    {
        public ClientTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=3306;database=alan_falcon_test;Allow User Variables=True";
        }
        public void Dispose()

        {
          Client.ClearAll();
        }
        [TestMethod]
        public void Save_SaveClient_0()
        {
            int numOfClients = Client.GetAll().Count;
            List<Client> testClient = new List<Client>();
            Client clientA = new Client("test-lastname","test-firstname");
            testClient.Add(clientA);
            clientA.Save();
            int newNumOfClients = Client.GetAll().Count;

            Assert.AreEqual(true,newNumOfClients > numOfClients);
        }
        [TestMethod]
        public void ClearAll_ClearAllClientsFromDatabase_0()
        {
            List<Client> testList = new List<Client>();
            Client clientA = new Client("Farron", "Alan");
            Client clientB = new Client("Murphy", "Brenda");
            Client clientC = new Client("Zamera", "Charlie");
            testList.Add(clientA);
            testList.Add(clientB);
            testList.Add(clientC);
            clientA.Save();
            clientB.Save();
            clientC.Save();

            Client.ClearAll();
            List<Client> resultList = Client.GetAll();

            Assert.AreEqual(true,resultList.Count==0);
        }
        [TestMethod]
        public void GetAll_GetAllClientsFromDatabase_0()
        {
            List<Client> testList = new List<Client>();
            Client clientA = new Client("Farron", "Alan");
            Client clientB = new Client("Murphy", "Brenda");
            Client clientC = new Client("Zamera", "Charlie");
            testList.Add(clientA);
            testList.Add(clientB);
            testList.Add(clientC);
            clientA.Save();
            clientB.Save();
            clientC.Save();

            List<Client> resultList = Client.GetAll();

            Assert.AreEqual(true,resultList.Count==3);
        }
        [TestMethod]
        public void Find_FindAClientInDatabase_0()
        {
            Client.ClearAll();
            Client testClient = new Client("Richardson", "Bethany");
            testClient.Save();

            Client foundClient = Client.Find(1);

            Assert.AreEqual(testClient, foundClient);
        }
        [TestMethod]
        public void Delete_DeleteClientFromDatabase_0()
        {
            Client testClient = new Client("Richardson", "Bethany");
            int numOfClientsB4 = Client.GetAll().Count;

            testClient.Save();
            int newID = testClient.Id;
            Client.Delete(newID);
            int numOfClientsAfter =  Client.GetAll().Count;

            Assert.AreEqual(numOfClientsB4, numOfClientsAfter);
        }
        [TestMethod]
        public void UpdateClient_UpdateAClientInDatabase_0()
        {
            Client testClient = new Client("Richardson", "Bethany");
            int newId = testClient.Id;
            testClient.Save();

            string newLastName = "Coruso";
            string newFirstName = "Eliza";

            Client newClient = new Client(newLastName, newFirstName);
            newClient.UpdateClient(testClient.Id, newClient.LastName, newClient.FirstName);

            Assert.AreNotEqual(testClient.LastName, newClient.LastName);
            Assert.AreNotEqual(testClient.FirstName, newClient.FirstName);
        }
    }
  }
