using Microsoft.Playwright;

namespace PlaywrightTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        //Assert.Pass();
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless = false});
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://qa-navigator.creditunionsfirst.org/login");
        await page.ClickAsync(selector:"text=SIGN IN");
        await page.ScreenshotAsync(new PageScreenshotOptions{Path = "Eapp.jpg"});

    }
}