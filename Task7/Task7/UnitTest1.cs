using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Task7
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver();

        [TestInitialize]
        public void Initilize()
        {
            //maximize the browser
            driver.Manage().Window.Maximize();

            //set Implicit Time Wait as well
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TestMethod]
        public void TestMethod0()
        {
            try
            {
                //set url of driver 
                driver.Url = "http://google.com";

                //finding element with the Name "q" and entering "Regression Testing" there, after that enter is pressed (keyboard)
                driver.FindElement(By.Name("q")).SendKeys("Regression Testing" + Keys.Enter);

                // press browser's back button
                driver.Navigate().Back();

                // press browser's front button
                driver.Navigate().Forward();

                // refresh current page
                driver.Navigate().Refresh();

                //current page title from the browser
                Console.WriteLine(driver.Title);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered : " + e);
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                // to go to this url
                driver.Url = "http://facebook.com";

                //extract "username or email" field from the login page and entered the provided email there
                driver.FindElement(By.Id("email")).SendKeys("enter your email");

                //extract "password" field and entered the provided password and press enter (keyboard)
                driver.FindElement(By.Id("pass")).SendKeys("password" + Keys.Enter);

                // extract the profile element and click 
                driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/']")).Click();

                //extract the "Friends" tab and click 
                driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")).Click();

                // verify

                //this variable contains true if the mentioned element is displayed
                bool a = driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")).Displayed;

                //information about the element returned by FindElement
                Console.WriteLine(driver.FindElement(By.XPath("//*[@href='https://www.facebook.com/tanisha.garg.94617/friends']")));

                //just to check
                Console.WriteLine(a == true);

                //assert 
                Assert.AreEqual(a, true);

                //assert
                Assert.IsTrue(a); // preferable
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception encountered : " + e);
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            //closes the browser
            driver.Close();

            //most important step
            driver.Quit();
        }
    }
}
