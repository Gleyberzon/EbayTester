using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class Filter
    {
        private IWebElement filter;
        public Filter(IWebElement filter)
        {
            this.filter = filter;
        }
    }
}
