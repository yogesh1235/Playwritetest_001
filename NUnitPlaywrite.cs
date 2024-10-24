using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace Playwritetest_001
{
    public class NUnitPlaywrite : PageTest

    {

        [SetUp]
        public async Task Setup()
        {

            await Page.GotoAsync(url: "http://www.eaapp.somee.com");
            

        }

        [Test]
        public async Task TestPage()
        {

           

            await Page.ClickAsync(selector:"text=Login");
            
            // fill text into filed 
            await Page.FillAsync(selector: "#UserName", value: "admin");
            await Page.FillAsync(selector: "#Password", value: "password");
            await Page.ClickAsync(selector: "text=Log in");
            await Expect(Page.Locator(selector: "text = Employee Details")).ToBeVisibleAsync();

        }
    }
}