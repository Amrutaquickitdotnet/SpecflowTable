using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowTable.CreateInstance;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTable.StepDefinitions
{
    [Binding]
    public class LoginFunctionality_StepDefinitions
    {
        IWebDriver driver;
        [Given(@"OrangeHrm Home Page")]
        public void GivenOrangeHrmHomePage()
        {
            driver = new ChromeDriver();
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            driver.Manage().Window.Maximize();
		}

        [When(@"User enter Credentials")]
        public void WhenUserEnterCredentials(Table table)

        {
            Thread.Sleep(5000);
        var credentials = table.CreateInstance<Credentials>();
            driver.FindElement(By.XPath("//*[@id='app']/div[1]/div/div[1]/div/div[2]/div[2]/form/div[1]/div/div[2]/input")).SendKeys(credentials.Username);
			driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(credentials.password);
            
		}

        [When(@"Click on Login Button")]
        public void WhenClickOnLoginButton()
        {
            Thread.Sleep(2000);
			driver.FindElement(By.XPath("//button[@type='submit']")).Click();
		}

        [Then(@"Successful login message should displayed\.")]
        public void ThenSuccessfulLoginMessageShouldDisplayed_()
        {
            Console.WriteLine("Login Successfully");
        }
    }
}
