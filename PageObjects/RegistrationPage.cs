using LongRichAutomationUI.Common.Utilities;
using LongRichAutomationUI.Hooks;
using LongRichAutomationUI.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LongRichAutomationUI.PageObjects
{
   public class RegistrationPage
    {

        public IWebDriver driver;



        
        
        Waits _wait;
        UIHelper helper;
        FileLocations _fileLocations;
        //ElementActions _elementActions;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
            
            _wait = new Waits();
            helper = new UIHelper();
            _fileLocations = new FileLocations();
            //_elementActions = new ElementActions();
           //
           //PageFactory.InitElements(BaseTest.driver, this);
        }
        private By country = By.CssSelector("div.topnav.topnav--lang.align-self-center > div > a > span.topnav-item--text");
        private By countryType = By.CssSelector(" div.site-header-top-right.d-flex > div.topnav.topnav--lang.align-self-center > div > div > ul > li.toplang-item.active > a"); 
        private By register = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(2) > a > span");
        private By firstName = By.Id("firstname");
        private By lastName = By.Id("lastname");
        private By email = By.CssSelector("#emailaddressreg");
        private By phoneNumber = By.Id("telephone");
        private By password = By.CssSelector("#passwordreg");
        private By confirmPassword = By.CssSelector("#cnpassword");
        private By streetAddress = By.CssSelector("#address");
        private By townCity = By.CssSelector("#city");
        private By state = By.CssSelector("#state");
        private By createAccount = By.CssSelector("#btn_register");
        private By successNotification = By.CssSelector("#dialoguetitle");


        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void ClickCountry()
        {
            driver.FindElement(country).Click();
        }

        public void ClickCountryType()
        {
            driver.FindElement(countryType).Click();
        }
       
        public void ClickRegister()
        {
            driver.FindElement(register).Click();
        }


        public void EnterFirstName(string firstNametxt)
        {
            driver.FindElement(firstName).SendKeys(firstNametxt);
        }

        public void EnterLastName(string lastNametxt)
        {
            driver.FindElement(lastName).SendKeys(lastNametxt);
        }

        public void EnterEmail(string emailtxt)
        {
            driver.FindElement(email).SendKeys(emailtxt);
        }

        public void EnterPhoneNumber(string phoneNumbertxt)
        {
            driver.FindElement(phoneNumber).SendKeys(phoneNumbertxt);
        }

        public void EnterPassword(string passwordtxt)
        {
            driver.FindElement(password).SendKeys(passwordtxt);
        }

        public void EnterConfirmPassword(string confirmPasswordtxt)
        {
            driver.FindElement(confirmPassword).SendKeys(confirmPasswordtxt);
        }

        public void EnterStreetAddress(string streettxt)
        {
            driver.FindElement(streetAddress).SendKeys(streettxt);
        }

        public void EnterTownCity(string townCitytxt)
        {
            driver.FindElement(townCity).SendKeys(townCitytxt);
        }

        public void EnterState(string statetxt)
        {
            driver.FindElement(state).SendKeys(statetxt);
        }

        public void ClickCreateAccount()
        {
            driver.FindElement(createAccount).Click();
        }


        public bool IsUserRegistered()
        {
            return driver.FindElement(successNotification).Displayed;
        }

       /* public bool IsUserRegisteredWithContain()
        {
            return driver.FindElement(successNotification).Text == ("SUCCESS NOTIFICATION");
        }

        public bool IsUserRegisteredSteps()
        {
            return driver.Url == ("https://longrichway.com/home/register");
        }

        public bool IsUserRegisteredWithSteps()
        {
            return driver.Url.Contains("longrichway.com/home/register");
        } */

    }
}
