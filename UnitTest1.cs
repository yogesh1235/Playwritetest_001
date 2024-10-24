using Microsoft.Playwright;

namespace Playwritetest_001
{
    public class Tests
    {
        

        [Test]
        public async Task Test1()
        {

            //Playwrite 

             var playwrite = await Playwright.CreateAsync();

            // Browser 

             var browser = await playwrite.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            // Page 

            var page = await browser.NewPageAsync();

            await page.GotoAsync(url: "http://www.eaapp.somee.com");
            await page.ClickAsync(selector:"text=Login");
            await page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "ScrennShot_001.jpg"
            });

            // fill text into filed 
            await page.FillAsync(selector: "#UserName", value: "admin");
            await page.FillAsync(selector: "#Password", value: "password");
            await page.ClickAsync(selector: "text=Log in");
            var isExist = await page.Locator(selector:"text = Employee Details").IsVisibleAsync();
            Assert.IsTrue(isExist); 
        }
    }
}