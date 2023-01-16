using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class ResultList
    {
        private IWebElement resultList;
        private IWebDriver driver;
        public ResultList(IWebElement resultList, IWebDriver driver)
        {
            this.resultList = resultList;
            this.driver = driver;
        }
        public List<IWebElement> GetItemsWithPriceMore50()
        {
            return resultList.FindElements(By.XPath("//div"));
        }
    }


}
