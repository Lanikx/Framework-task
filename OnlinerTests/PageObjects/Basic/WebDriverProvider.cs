using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OnlinerTests.PageObjects.Basic
{
    public static class WebDriverProvider
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public static IWebDriver Driver
        {
            get
            {
                return _storedDriver.Value;
            }
            set
            {
                _storedDriver.Value = CreateDriver();
            }
        }

        public static void Start()
        {
            Driver = null; // Not sure I get the idea

        }

        public static IWebDriver CreateDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-gpu");
            return new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));
        }


        public void Quit()
        {
            driver.Quit();
        }
    }
}
