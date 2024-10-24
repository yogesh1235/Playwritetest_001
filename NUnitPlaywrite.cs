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

            //To Use like page object model
            var lknlogin = Page.Locator("text=Login");
            await lknlogin.ClickAsync();
            
            // fill text into filed 
            await Page.FillAsync( "#UserName", value: "admin");
            await Page.FillAsync( "#Password", value: "password");
            await Page.ClickAsync( "text=Log in");
            await Expect(Page.Locator("text = Employee Details")).ToBeVisibleAsync();

        }
    }
}