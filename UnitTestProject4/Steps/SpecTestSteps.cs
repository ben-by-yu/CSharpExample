using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using UnitTestProject4.Pages;
using NUnit.Framework;

namespace UnitTestProject4.Steps
{
    [Binding]
    public class GoogleSearchFunctionalityTestSteps
    {
        IWebDriver _driver;
        //BasePage page;
        SearchPage searchPage;
        MailLoginPage mailPage;
        public GoogleSearchFunctionalityTestSteps(IWebDriver webDriver)
        // public GoogleSearchFunctionalityTestSteps()
        {
            _driver = webDriver;
            searchPage = new SearchPage(_driver);
            mailPage = new MailLoginPage(_driver);
        }

        [Given(@"I am on google serach web page")]
        public void GivenIAmOnGoogleSerachWebPage()
        {
            _driver.Url = "https://www.google.com";
            
        }

        [When(@"I input search text")]
        public void WhenIInputSearchText()
        {
            searchPage.input_search_text("Master Chief");
        }
        
        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
            searchPage.click_submit_btn();       
        }
        
        [Then(@"I should see search result")]
        public bool ThenIShouldSeeSearchResult()
        {
            return searchPage.verify_title("Master Chief - Google Search");
        }

        [Given(@"I am on mail web page")]
        public void GivenIAmOnMailWebPage()
        {
            _driver.Url = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1535175553&rver=6.7.6640.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fauthRedirect%3dtrue%26RpsCsrfState%3dc3c04969-2820-daff-e8e4-9f761da00cdf&id=292841&whr=outlook.com&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=90015";
        }

        [When(@"I input username and password")]
        public void WhenIInputUsernameAndPassword(Table table)
        {
            dynamic userInfo = table.CreateDynamicInstance();
            mailPage.input_mail_passwd(userInfo.username, userInfo.password);
        }

        [Then(@"I should see inbox")]
        public void ThenIShouldSeeInbox()
        {
            Console.WriteLine("This is the last step.");
            //Assert.AreEqual(_driver.Title, "Continue");
        }

    }
}
