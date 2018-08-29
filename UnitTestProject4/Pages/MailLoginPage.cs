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
    public class MailLoginPage : BasePage
    {
        WebDriverWait waitNextElem;
        public MailLoginPage(IWebDriver webDriver) : base(webDriver)
        {
            waitNextElem = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
        IWebElement inputMail => _driver.FindElement(By.XPath("//*[@id=\"i0116\"]"));
        // IWebElement nextBtn => _driver.FindElement(By.XPath("//*[@id=\"idSIButton9\"]"));
        IWebElement nextBtn => _driver.FindElement(By.CssSelector("#idSIButton9"));
        IWebElement inputPasswd => _driver.FindElement(By.XPath("//*[@id=\"i0118\"]"));
        // IWebElement loginBtn => _driver.FindElement(By.XPath("//*[@id=\"idSIButton9\"]"));
        // IWebElement loginBtn => _driver.FindElement(By.CssSelector("#idSIButton9"));
        IWebElement loginBtn => _driver.FindElement(By.CssSelector(".inline-block"));

        public void input_mail_passwd(string mailAddress, string passwd)
        {
            inputMail.SendKeys(mailAddress);
            waitNextElem.Until(_driver => _driver.FindElement(By.CssSelector("#idSIButton9")));
            nextBtn.Click();
            waitNextElem.Until(_driver => _driver.FindElement(By.CssSelector("#i0118")));
            inputPasswd.SendKeys(passwd);
            // waitNextElem.Until(_driver => _driver.FindElement(By.CssSelector("#idSIButton9")));
            waitNextElem.Until(_driver => _driver.FindElement(By.CssSelector(".inline-block")));
            loginBtn.Click();
        }

    }
}
