using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject4.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver webDriver) : base(webDriver)
        {

        }

        IWebElement searchTextBox => _driver.FindElement(By.Name("q"));
        IWebElement submitBtn => _driver.FindElement(By.XPath("/html/body/div/div[3]/form/div[2]/div[3]/center/input[1]"));

        public void input_search_text(string searchText)
        {
            searchTextBox.SendKeys(searchText);
        }

        public void click_submit_btn()
        {
            submitBtn.Click();
        }
    }
}
