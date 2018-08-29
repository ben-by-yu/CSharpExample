using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject4.Pages
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver) => _driver = driver;

        public bool verify_title(string expected_title)
        {
            return _driver.Title.Equals(expected_title);
            
            //if (_driver.Title == expected_title)
            //    return true;
            //else
            //    return false;
        }





    }
}
