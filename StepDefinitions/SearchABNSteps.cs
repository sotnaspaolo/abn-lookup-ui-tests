using Microsoft.Playwright;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AbnLookupTests.StepDefinitions
{
    [Binding]
    public class SearchABNSteps
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;

        [BeforeScenario]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true
            });
            _page = await _browser.NewPageAsync();
        }

        [Given(@"I navigate to the ABN Lookup website")]
        public async Task GivenINavigateToTheABNLookupWebsite()
        {
            await _page.GotoAsync("https://abr.business.gov.au/");
        }

        [When(@"I enter the ABN ""(.*)""")]
        public async Task WhenIEnterTheABN(string abn)
        {
            await _page.FillAsync("#SearchText", abn);
        }

        [When(@"I enter the ACN ""(.*)""")]
        public async Task WhenIEnterTheACN(string acn)
        {
            await _page.FillAsync("#SearchText", acn);
        }

        [When(@"I enter the business name ""(.*)""")]
        public async Task WhenIEnterTheBusinessName(string name)
        {
            await _page.FillAsync("#SearchText", name);
        }

        [When(@"I click on the search button")]
        public async Task WhenIClickOnTheSearchButton()
        {
            await _page.ClickAsync("#MainSearchButton.default");
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        [Then(@"I should see the business name ""(.*)""")]
        public async Task ThenIShouldSeeTheBusinessName(string expectedName)
        {
            var resultText = await _page.InnerTextAsync(".container-content");
            ClassicAssert.IsTrue(resultText.Contains(expectedName), $"Expected {expectedName} but found {resultText}");
        }

        [Then(@"I should see results related to ""(.*)""")]
        public async Task ThenIShouldSeeResultsRelatedTo(string expectedBusinessName)
        {
            var resultText = await _page.TextContentAsync(".table-wrapper"); 
            Assert.That(resultText.Contains(expectedBusinessName), $"Expected {expectedBusinessName} but found {resultText}");
        }


        [AfterScenario]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
            _playwright.Dispose();
        }
    }
}
