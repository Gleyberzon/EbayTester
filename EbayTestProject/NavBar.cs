using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayTestProject
{
    class NavBar
    {
        private IWebElement navbar;
        public NavBar(IWebElement navbar) { 
            this.navbar = navbar;
        }
    }
}
