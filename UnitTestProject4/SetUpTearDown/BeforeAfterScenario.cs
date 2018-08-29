using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using UnitTestProject4.Pages;
using OpenQA.Selenium.Firefox;
using BoDi;

namespace UnitTestProject4.SetUpTearDown
{


    [Binding]
    public class BeforeAfterScenario
    {
        IWebDriver webDriver;
        private readonly IObjectContainer objectContainer;
        public BeforeAfterScenario(IObjectContainer objectContainer)
        {
            this.webDriver = new FirefoxDriver(); 
            this.objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            // Context injection so webDriver could be called in step definition
            objectContainer.RegisterInstanceAs<IWebDriver>(webDriver);
        }



        [AfterScenario]
        public void AfterScenario()
        {
            // webDriver.Close();
        }

    }

}

