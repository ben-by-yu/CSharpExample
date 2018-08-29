using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UnitTestProject4.SetUpTearDown
{
    [Binding]
    public class BeforeAfterFeature
    {
        [BeforeFeature]
        public static void BeforeFeature()
        {
            // Console.WriteLine("==============================This is the hook before feature!==============================");
        }

        [AfterFeature]
        public static void AfterFeature()
        {

        }
    }
}
