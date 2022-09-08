using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProject19.PageObject;

namespace TestProject19.StepDefinition
{
    [Binding]
    public class SignUpSteps
    {

        SignUpPage signUpPage;

        public SignUpSteps() 
        {
            signUpPage = new SignUpPage();
        }

            
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            //ScenarioContext.Current.Pending();

            signUpPage.NavigateToWebSite();

        }
        
        [Given(@"I enter my Username")]
        public void GivenIEnterMyUsername()
        {
            //ScenarioContext.Current.Pending();
            signUpPage.EnterUserName();
        }
        
        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            //ScenarioContext.Current.Pending();
            signUpPage.EnterEmail();
        }
        
        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            //ScenarioContext.Current.Pending();
            signUpPage.EnterPassword();
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSingUp()
        {
            //ScenarioContext.Current.Pending();
            signUpPage.ClickSignUpButton();
        }
        
        [Then(@"I should be able to register succesfully")]
        public void ThenIShouldBeAbleToRegisterSuccesfully()
        {
            //ScenarioContext.Current.Pending();
            Thread.Sleep(5000);
            Assert.That(signUpPage.IsPopularTagDisplayed);
        }
    }
}
