using LinkedInCI.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCI
{
    public class Linkedin
    {
       public  IWebDriver driver;
        [OneTimeSetUp]
        public void Initial()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com/login";
        }

        [Test]
        public void LoginTest()
        {
            LoginPage page = new LoginPage(driver);
            page.Login();
            driver.Close();
        }

       /* [Test]
        public void LogOutTest()
        {
            HomePage page = new HomePage(driver);
            page.LogOut();
        }*/
    }
}
