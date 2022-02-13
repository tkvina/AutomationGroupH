using AutomationDemoSiteTest.NewFolder.PageObject;
using System;
using TechTalk.SpecFlow;

namespace AutomationDemoSiteTest.StepDefinitions
{
    [Binding]
    public class AutomationDemoSteps
    {
        AutomationDemoPage1 automationDemoPage1;

        public AutomationDemoSteps()
        {
            automationDemoPage1 = new AutomationDemoPage1();
        }
    
       
   
        [Given(@"I navigate to website")]
        public void GivenINavigateToWebsite()
        {
            automationDemoPage1.NavigateToWebsite();
        }
        
        [Given(@"I click on Register")]
        public void GivenIClickOnRegister()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my first name")]
        public void GivenIEnterMyFirstName()
        {
            automationDemoPage1.Enterfirstname();
        }
        
        [Given(@"I enter my last name")]
        public void GivenIEnterMyLastName()
        {
            automationDemoPage1.Enterlastname();
        }
        
        [Given(@"I enter my Address")]
        public void GivenIEnterMyAddress()
        {
            automationDemoPage1.Enteraddress();
        }
        
        [Given(@"I enter my Email address")]
        public void GivenIEnterMyEmailAddress()
        {
            automationDemoPage1.EnterEmailAddress();
        }
        
        [Given(@"I enter phone number")]
        public void GivenIEnterPhoneNumber()
        {
            automationDemoPage1.EnterPhoneNumber();
        }
        
        [Given(@"I enter my gender")]
        public void GivenIEnterMyGender()
        {
            automationDemoPage1.EnterGender();

        }
        
        [Given(@"I enter my hobbies")]
        public void GivenIEnterMyHobbies()
        {
            automationDemoPage1.EnterHobbies();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            automationDemoPage1.EnterPassword();
        }
        
        [Given(@"I confirmed my Password")]
        public void GivenIConfirmedMyPassword()
        {
            automationDemoPage1.EnterConfirmedPassword();
        }
        
        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            automationDemoPage1.SubmitButton();
        }
        
        [Then(@"I should be able to register an account")]
        public void ThenIShouldBeAbleToRegisterAnAccount()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
