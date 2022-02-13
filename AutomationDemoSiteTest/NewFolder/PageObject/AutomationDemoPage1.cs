using AutomationDemoSiteTest.NewFolder.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationDemoSiteTest.NewFolder.PageObject
{
    class AutomationDemoPage1
    {

        public AutomationDemoPage1()
        {
            driver = AutomationDemoHooks1.driver;
        }
            IWebDriver driver;
        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[1]/input "));

        IWebElement lastname => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[2]/input "));

        IWebElement address => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[2]/div/textarea "));

        IWebElement EmailAddress => driver.FindElement(By.XPath("//*[@id='eid']/input "));

        IWebElement PhoneNumber => driver.FindElement(By.XPath(" //*[@id='basicBootstrapForm']/div[4]/div/input"));

        IWebElement Gender => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[5]/div/label[2] "));

        IWebElement Hobbies => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[6]/div/div[1]/label "));

        IWebElement Password => driver.FindElement(By.XPath(" //*[@id='firstpassword']"));

        IWebElement ConfirmedPassword => driver.FindElement(By.XPath("//*[@id='secondpassword'] "));

        IWebElement ClickOnSubmitButton => driver.FindElement(By.XPath(" //*[@id='submitbtn']"));

        public void Enterfirstname()
        {
            firstName.SendKeys("TerryG");
        }
        public void Enterlastname()
        {
            lastname.SendKeys("brown");
        }
        public void Enteraddress()
        {
            address.SendKeys(" 12 sandwish avenue ohio usa");
        }
        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys(" tina@gmail.com");
        }
        public void EnterPhoneNumber()
        {
            PhoneNumber.SendKeys(" 07975623900");
        }
        public void EnterGender()
        {
            Gender.SendKeys("Female");
        }
        public void EnterHobbies()
        {
            Hobbies.Click();
        }
        public void EnterPassword()
        {
            Password.SendKeys(" ohiooo1");
        }
        public void EnterConfirmedPassword()
        {
            ConfirmedPassword.SendKeys("ohiooo1");
        }
        public void SubmitButton()
        {
            ClickOnSubmitButton.Click();
        }
        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("http://demo.automationtesting.in/Register.html ");
        }

















    }
}
