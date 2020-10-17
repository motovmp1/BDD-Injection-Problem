using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject3
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("=================== CALL BEFORE EVERY CENARIO =====================");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("===============  CALL AFTER EVERY CENARIO =====================");
        }
    }
}
