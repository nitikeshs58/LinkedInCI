using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedInCI.Pages
{
   public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement Userid;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[@type = 'submit']")]
        public IWebElement SignIn;

        public void Login()
        {
            
            Userid.SendKeys("nitikeshs58@gmail.com");
            Password.SendKeys("niti8390");
            SignIn.Click();
        }
    }
}
