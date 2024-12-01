using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace YourProjectNamespace
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;
        private CustomerPage customerPage;
        private CustomerOperationsPage customerOperationsPage;

        public LoginSteps()
        {
            
            driver = new ChromeDriver(); 
            loginPage = new LoginPage(driver);
            customerPage = new CustomerPage(driver);
            customerOperationsPage = new CustomerOperationsPage(driver);
        }

        [Given(@"I am on the banking website")]
        public void GivenIAmOnTheBankingWebsite()
        {
            loginPage.OpenLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject"); 
        }

        [When(@"I select ""Login as User"" option")]
        public void WhenISelectLoginAsUserOption()
        {
            loginPage.ClickLoginAsUser();
        }

        [When(@"I select ""Hermoine Granger"" as a customer")]

        public void WhenISelectHarryPotter()
        {
            customerPage.SelectCustomer("Hermoine Granger");
        }

        [When(@"I click Login button")]

        public void WhenIClickLoginButton()
        {
            customerPage.ClickLogin();
        }

        [Then(@"I should be on the bank's home page")]
        public void ThenIShouldSeeTheMainDivBlock()
        {
            bool isMainDivVisible = customerOperationsPage.IsWelcomeTextVisible();
            Assert.IsTrue(isMainDivVisible, "The 'mainBox' block is not visible.");
        }

        [When(@"I click the Withdrawl button")]

        public void WhenIClickWithdraw()
        {
            customerOperationsPage.OpenWithdrawMenu();
        }

        [When(@"I enter the withdrawal amount as full sum / 2")]
        public void EnterAmount()
        {
            customerOperationsPage.EnterAmount();
        }

        [When(@"I click the ""Confirm Withdrawal"" button")]
        public void ConfirmWithdraw()
        {
            customerOperationsPage.ClickWithdraw();
        }

        [Then(@"I should see a success message")]
        public void ThenIShouldSeeASucseedMessage()
        {
            customerOperationsPage.IsSucseedTextVisible();
        }

        [When(@"I enter the withdrawal amount as full sum x 2")]

        public void EnterMoreAmount()
        {
            customerOperationsPage.EnterMoreAmount();
        }

        [When(@"I click the ""Confirm Withdrawal"" button again")]

        public void ClickWithdrawAgain()
        {
            customerOperationsPage.ClickWithdraw();
        }

        [Then(@"I should see an error message")]
        public void ThenIShoulSeeAnError()
        {
            customerOperationsPage.IsErrorTextVisible();
        }

        [Then(@"I should close Chrome")]
        public void CloseChrome()
        {
            customerOperationsPage.CloseDriver();
        }
    }
}