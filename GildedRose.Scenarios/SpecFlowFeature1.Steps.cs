using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRose.Console;
using TechTalk.SpecFlow;

namespace GildedRose.Scenarios
{
    [Binding]
    public class SpecFlowFeature1
    {
        [Given(@"I create Program")]
        public void GivenICreateProgram()
        {
            var program = new Program();
        }

    }
}
