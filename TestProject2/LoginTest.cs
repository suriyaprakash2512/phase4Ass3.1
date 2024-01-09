using UserLoginLib;

namespace TestProject2
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
            public void SuccessMethod()
            {
                string expResult = "valid user";
                Assert.AreEqual(expResult, Login.Authenicate("sam", "sam@1256"));
            }
            [TestMethod]
            public void FailMethod()
            {
                string expResult = "invalid user credential";
                Assert.AreEqual(expResult, Login.Authenicate("ravi", "raj@124"));
            }
         
        }
    }
