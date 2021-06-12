using LongRichAutomationUI.Common.Utilities;
using LongRichAutomationUI.Hooks;
using LongRichAutomationUI.Utilities;
using OpenQA.Selenium;
//using PageFactoryCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LongRichAutomationUI.PageObjects
{
    class PaymentPage
    {
        public IWebDriver driver;
        //Waits _wait;
        //UIHelper helper;
        //FileLocations _fileLocations;
        //ElementActions _elementActions;

     
            


        public PaymentPage()
        {                               
            driver = BaseTest.driver;
            //_wait = new Waits();
            //helper = new UIHelper();
            //_fileLocations = new FileLocations();
            //_elementActions = new ElementActions();
            //PageFactory.InitElements(BaseTest.driver, this);



        }

        private By country = By.CssSelector("div.topnav.topnav--lang.align-self-center > div > a > span.topnav-item--text");
        private By countryType = By.CssSelector("div.site-header-top-right.d-flex > div.topnav.topnav--lang.align-self-center > div > div > ul > li.toplang-item.active > a");
        private By signIn = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(1) > a");
        private By email = By.CssSelector("#emailaddress");
        private By password = By.CssSelector("#password");
        private By login = By.CssSelector("#btn_login");
        private By categories = By.CssSelector("#menu-main-menu > li:nth-child(2) > a");
        private By faminineCare = By.CssSelector("#menu-main-menu > li:nth-child(2) > ul > li:nth-child(2) > a");
        private By featuredProducts = By.CssSelector("#page_wrapper > section > div > div > div.col-sm-12.col-md-8.mb-30 > div > div > div > div:nth-child(2) > div > div > div > div.product-image3 > a > img.pic-2");
        private By quantity = By.CssSelector("div.quantity > input");
        private By addToCart = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9 > div > div.row.product-page > div.main-data.col-sm-12.col-md-7.col-lg-7 > div > form > div > div.variations_button > button");
        private By cart = By.CssSelector("#cart_area > a > i");
        private By viewCart = By.CssSelector("#cart_area > div > div > div > p.buttons > a:nth-child(1)");
        private By proceedToCheckout = By.CssSelector("#content > div > div > div.right_sidebar.col-sm-12.col-md-12.col-lg-9.mb-md-50 > div.text_box > div > div > div > div > a");
        private By payStack = By.CssSelector("#paystack");
        private By homeDelivery = By.CssSelector("#shipping_home");
        private By existingAddress = By.CssSelector(" div.col-lg-12.mb-20 > div:nth-child(1) > div.panel-default");
        private By comment = By.CssSelector("#custom_field");
        private By completeOrder = By.CssSelector("#btn_order");
        private By card = By.CssSelector("#app > section > div > div > div.checkout__nav > nav > ul > li.nav__item.active");
        private By iFrame = By.CssSelector("#app > section > div > div > div.checkout__core");
        private By frame = By.CssSelector("#test-cards > div.cards > div.card.card--is-active > div");
        private By successCard = By.CssSelector("#test-cards > div.cards > div:nth-child(1) > div > div.card__details__select");
        private By pay = By.CssSelector("#test-cards > button");
        private By paymentMadeSuccessfully = By.CssSelector("#dialoguetext");
        
        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickCountry()
        {
           // _elementActions.Click(country);
            driver.FindElement(country).Click();
        }

        public void ClickCountryType()
        {
            driver.FindElement(countryType).Click();
        }

        public void ClickSignIn()
        {
            driver.FindElement(signIn).Click();
        }

        public void EnterEmail(string emailtxt)
        {
            driver.FindElement(email).SendKeys(emailtxt);
        }

        public void EnterPassword(string passwordtxt)
        {
            driver.FindElement(password).SendKeys(passwordtxt);
        }

        public void ClickLogin()
        {
            driver.FindElement(login).Click();
        }

        public void ClickCategories()
        {
            driver.FindElement(categories).Click();
        }
        public void ClickFaminineCare()
        {
            driver.FindElement(faminineCare).Click();
        }

        public void ClickFeaturedProducts()
        {
            driver.FindElement(featuredProducts).Click();
        }


        public void EnterQuantity(string numbertxt)
        {
            driver.FindElement(quantity).Clear();
            driver.FindElement(quantity).SendKeys(numbertxt);
            
        }

        public void ClickAddToCart()
        {
            driver.FindElement(addToCart).Click();
        }
        

        public void ClickCart()
        {
            driver.FindElement(cart).Click();
        }
        

        public void ClickViewCart()
        {
             driver.FindElement(viewCart).Click();
        }

        public void ClickProceedToCheckout()
        {
           // Thread.Sleep(5000);
            driver.FindElement(proceedToCheckout).Click();
        }

        public void ClickPayStack()
        {
            driver.FindElement(payStack).Click();
        }

        public void ClickHomeDelivery()
        {

            driver.FindElement(homeDelivery).Click();
        }

        public void ClickExistingAdress()
        {
            driver.FindElement(existingAddress).Click();
        }

        public void EnterComment(string commenttxt)
        {
            driver.FindElement(comment).SendKeys(commenttxt);
        }

        public void ClickCompleteOrder()
        {
            driver.FindElement(completeOrder).Click();
            
        }

        public void ClickCard()
        {
            driver.FindElement(card).Click();
        }

        public void ClickSuccessCard()
        {
             driver.FindElement(iFrame).Click();
             driver.FindElement(frame).Click()
;            driver.SwitchTo().Frame(0);
             //Thread.Sleep(10000);
            driver.FindElement(successCard).Click();
            driver.SwitchTo().DefaultContent();
            
        }

        public void ClickPay()
        {
            driver.FindElement(pay).Click();
        }

        public bool IsPaymentMadeSuccessfullyWithContains()
        {
            return driver.FindElement(paymentMadeSuccessfully).Text.Contains("payment made successfully");
        }


















    }
}
