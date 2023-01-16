using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class BrowserFactory
    {
        private Dictionary<string, IWebDriver> drivers;

        public BrowserFactory()
        {
            drivers = new Dictionary<string, IWebDriver>();
        }

        public Dictionary<string, IWebDriver> Drivers
        {
            get
            {
                return drivers;
            }
            private set
            {
                Drivers = value;
            }
        }

        public void InitBrowser(string browserName)
        {
            if (!drivers.ContainsKey(browserName.ToUpper()))
            {
                IWebDriver driver;
                switch (browserName.ToUpper())
                {
                    case "FIREFOX":
                        driver = new EdgeDriver("C:\\Drivers\\firefox");
                        drivers.Add(browserName.ToUpper(), driver);
                        break;

                    case "EDGE":
                        driver = new EdgeDriver("C:\\Drivers\\edge");
                        drivers.Add(browserName.ToUpper(), driver);
                        break;

                    case "CHROME":
                    default:
                        driver = new ChromeDriver("C:\\Drivers\\chrome");
                        drivers.Add(browserName.ToUpper(), driver);
                        break;
                }
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }

        }

        public void LoadApplication(IWebDriver driver, string url)
        {
            driver.Url = url;
        }

        public void CloseAllDrivers()
        {
            if (drivers != null)
            {
                foreach (var key in drivers.Keys)
                {
                    drivers[key].Close();
                    drivers[key].Quit();
                }
            }
        }
    }

    public class Tests
    {
        public IWebDriver chrome;
        //public IWebDriver edge;
        //public IWebDriver firefox;

        BrowserFactory browserFactory;
        [SetUp]
        public void Setup()
        {
            browserFactory = new BrowserFactory();

            browserFactory.InitBrowser("chrome");
            //browserFactory.InitBrowser("edge");
            //browserFactory.InitBrowser("firefox");

            chrome = browserFactory.Drivers["CHROME"];
            //edge = browserFactory.Drivers["EDGE"];
            //firefox = browserFactory.Drivers["FIREFOX"];
        }

        [Test]
        public void Test1()
        {
            //browserFactory.LoadApplication(chrome, "https://www.ebay.com/");
            //browserFactory.LoadApplication(edge, "https://www.ebay.com/");
            //browserFactory.LoadApplication(firefox, "https://www.ebay.com/");
            EbayTester tester = new EbayTester(chrome);
            tester.HomePage.SearchBar.setText("mouse");
            tester.HomePage.SearchButton.Click();
            Assert.Pass();
        }
    }
    
}