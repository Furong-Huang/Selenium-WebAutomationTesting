using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Lyratesting2Project1.StepsDefinition
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void InitDriver()
        {
            Browser.InitDriver();
        }
        
        [AfterScenario]
        public static void AfterScenarioExecution()
        {
            Browser.Close();
        }
    }

    
}
