using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
                _storedDriver.Value = value;
            }
        }

        public static void Start()
        {
            Driver = CreateDriver(); 
            MaximizeWindow();
        }

        private static void MaximizeWindow()
        {
            Driver.Manage().Window.Maximize();
        }

        public static IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-gpu");
            return new ChromeDriver("D:\\", options, TimeSpan.FromMinutes(5));
        }

        public static void Quit()
        {
            Driver.Quit();
        }
    }
}
