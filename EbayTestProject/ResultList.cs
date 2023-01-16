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
        public void PrintItemsWithPriceMore50()
        {
            IList < IWebElement > list = resultList.FindElements(By.XPath("li//span[@class='s-item__price' and number(substring-after(text(), \"ILS \")) > 50]/../../../../.."));
            Console.WriteLine("There are "+list.Count()+" items:");
            foreach (IWebElement el in list)
            {
                string name = el.FindElement(By.XPath(".//div[@class='s-item__title']/span")).Text;
                string price = el.FindElement(By.XPath(".//span[@class='s-item__price']")).Text;
                Console.WriteLine(name + "\n" + price + "\n");
            }
        }
    }


}
