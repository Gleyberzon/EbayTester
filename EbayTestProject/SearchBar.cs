using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class SearchBar
    {
        private IWebElement searchBar;
        public SearchBar(IWebElement searchBar) 
        { 
            this.searchBar = searchBar;
        }

        public void setText(string text)
        {
            searchBar.SendKeys(text);
        }
    }
}
