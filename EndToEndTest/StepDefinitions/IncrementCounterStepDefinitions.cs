using System;
using TechTalk.SpecFlow;

namespace EndToEndTest.StepDefinitions
{
    [Binding]
    public class IncrementCounterStepDefinitions
    {
        public int counter;
        [Given(@"Counter button is clicked")]
        public void GivenCounterButtonIsClicked()
        {
        }
        [When(@"Counter value is (.*)")]
        public void WhenCounterValueIs(int p1)
        {
            counter = p1;
        }

        [Then(@"Counter value should increment by (.*)")]
        public void ThenCounterValueShouldIncrementBy(int p2)
        {
            counter += p2;
        }

    }
}
