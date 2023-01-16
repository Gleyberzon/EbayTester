using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    
    class SearchPage
    {
        public ResultList ResultList;
        List<IWebElement> Items;
        public SearchPage(IWebDriver driver)
        {
            ResultList =new ResultList(driver.FindElement(By.CssSelector("#srp-river-results > ul")), driver);
        }
    }
}
