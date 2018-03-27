using System;
using DataAccessTier;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            UserDataAccess data = new UserDataAccess();
            var user = data.getUsers();
            Assert.AreEqual(2, user.Count);
        }

        [TestMethod]
        public void TestMethod2()
        {
            UserDataAccess data = new UserDataAccess();
            var user = data.getUsers();
            Assert.AreEqual(-1, user.Count);
        }


        [TestMethod]
        public void TestAddNewUserMethod2()
        {
            UserDataAccess data = new UserDataAccess();
            var user1 = data.getUsers();
            int beforeAdding = user1.Count;
            User user = new User();
            user.FirstName = "UT";
            user.LastName = "UT";
            user.UserName = "UT";
            user.Password = "UT";
            data.AddUser(user);
            user1 = data.getUsers();
            int afterAdding = user1.Count;
            Assert.AreEqual(beforeAdding+1, afterAdding);
        }
    }
}
