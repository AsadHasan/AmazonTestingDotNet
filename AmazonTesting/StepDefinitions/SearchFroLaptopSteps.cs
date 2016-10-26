using System;
using TechTalk.SpecFlow;

namespace AmazonTesting.StepDefinitions
{
    [Binding]
    public class SearchFroLaptopSteps
    {
        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I select ""(.*)"" from the dropdown menu next to the search bar")]
        public void GivenISelectFromTheDropdownMenuNextToTheSearchBar(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I type ""(.*)"" in the search bar")]
        public void WhenITypeInTheSearchBar(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I select first suggestion from auto-complete")]
        public void WhenISelectFirstSuggestionFromAuto_Complete()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see results")]
        public void ThenIShouldSeeResults()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
