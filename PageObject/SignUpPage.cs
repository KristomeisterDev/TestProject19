using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject19.Utilities;

namespace TestProject19.PageObject
{
    class SignUpPage
    {

        public SignUpPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        IWebElement email => driver.FindElement(By.XPath("//input[@placeholder='Email']"));

        IWebElement password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement signUp => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > button"));

        IWebElement popularTags => driver.FindElement(By.XPath("//p[text()='Popular Tags']"));

        public void EnterUserName()
        {
            //using a random generator
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);

            username.SendKeys("TestProject" + randomInt);
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            email.SendKeys("cristian" + randomInt + "@globaltriangles.com");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void ClickSignUpButton()
        {
            signUp.Click();
        }

        public bool IsPopularTagDisplayed()
        {
            return popularTags.Displayed;
        }

        public void NavigateToWebSite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/register");
        }

    }
}
