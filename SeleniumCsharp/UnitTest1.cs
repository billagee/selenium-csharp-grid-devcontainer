using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace SeleniumCsharp;

public class Tests
{
    private IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        ChromeOptions options = new ChromeOptions();
        // Retrieve environment variables
        string seGridHost = Environment.GetEnvironmentVariable("GRIDHOST");
        string seGridPort = Environment.GetEnvironmentVariable("GRIDPORT");
        string gridUrl = $"http://{seGridHost}:{seGridPort}/wd/hub";

        // Instantiate remote session
        driver = new RemoteWebDriver(new Uri(gridUrl), options);
    }

    [Test]
    public void verifyLogo()
    {
        driver.Navigate().GoToUrl("https://www.browserstack.com/");
        ClassicAssert.IsTrue(driver.FindElement(By.XPath("//img[@alt='BrowserStack Logo']")).Displayed);
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
