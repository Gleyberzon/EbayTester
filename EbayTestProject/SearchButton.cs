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
        public SearchButton(IWebElement searchButton)
        {
            this.searchButton = searchButton;
        }

        public void Click()
        {
            searchButton.Click();
            
        }
    }
}
