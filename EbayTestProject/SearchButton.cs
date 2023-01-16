using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class SearchButton
    {
        private IWebElement searchButton;
        private IWebDriver driver;
        private EbayTester tester;
        public SearchButton(IWebElement searchButton, EbayTester tester, IWebDriver driver)
        {
            this.searchButton = searchButton;
            this.tester = tester;
            this.driver = driver;
        }

        public void Click()
        {
            searchButton.Click();
            tester.SearchPage = new SearchPage(driver);
            
        }
    }
}
