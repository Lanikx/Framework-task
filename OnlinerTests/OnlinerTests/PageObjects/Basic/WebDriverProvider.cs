using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace OnlinerTests.PageObjects.Basic
{
    public class WebDriverProvider
    {
        private static ThreadLocal<IWebDriver> _storedDriver = new ThreadLocal<IWebDriver>();

        public IWebDriver driver
        {
            get
            {
                return _storedDriver.Value;
            }
        }

        public void Start()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            options.AddArgument("disable-gpu");
            _storedDriver.Value = new ChromeDriver(ChromeDriverService.CreateDefaultService(), options, TimeSpan.FromMinutes(5));
        }


        public void Quit()
        {
            driver.Quit();
        }
    }
}
