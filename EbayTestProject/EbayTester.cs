using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class EbayTester
    {
        public HomePage HomePage;
        public SearchPage SearchPage;
        public EbayTester(IWebDriver driver)
        {
            HomePage = new HomePage(driver, this);
        }
    }
}
