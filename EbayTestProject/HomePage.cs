using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class HomePage
    {
        private EbayTester tester;
        public SearchBar SearchBar;
        public SearchButton SearchButton;
        public Filter Filter;
        public NavBar NavBar;
  

        public HomePage(IWebDriver driver, EbayTester tester) 
        {
            this.tester = tester;
            driver.Navigate().GoToUrl("https://www.ebay.com/");
            SearchBar = new SearchBar(driver.FindElement(By.CssSelector("#gh-ac")));
            SearchButton = new SearchButton(driver.FindElement(By.CssSelector("#gh-btn")), tester, driver);
            Filter = new Filter(driver.FindElement(By.CssSelector("#gh-cat")));
            NavBar = new NavBar(driver.FindElement(By.CssSelector("#mainContent > div.hl-cat-nav > ul")));
        }
    }
}
