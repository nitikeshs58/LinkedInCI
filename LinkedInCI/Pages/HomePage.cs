﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedInCI.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ember24")]
        public IWebElement AccountSetting;

        [FindsBy(How = How.Id, Using = "ember38")]
        public IWebElement Logout;

        public void LogOut()
        {
            Thread.Sleep(5000);
            AccountSetting.Click();
            Thread.Sleep(5000);
            Logout.Click();
        }
    }
}
