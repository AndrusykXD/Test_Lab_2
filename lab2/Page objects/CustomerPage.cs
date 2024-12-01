using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomerPage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public CustomerPage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }
    public void SelectCustomer(string customerName)
    {
        // Знайдіть елемент випадаючого списку за допомогою селектора
        IWebElement customerDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//option[text()='---Your Name---']")));
        customerDropdown.Click();
        Thread.Sleep(3000);

        // Знайдіть і виберіть варіант "Harry Potter" за текстом
        IWebElement customerOption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//option[text()='{customerName}']")));
        customerOption.Click();
        Thread.Sleep(3000);
    }

    public void ClickLogin()
    {
        IWebElement loginButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"//button[text()='Login']")));
        loginButton.Click();
        Thread.Sleep(3000);
    }
}
