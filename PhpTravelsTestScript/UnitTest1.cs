using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace PhpTravelsTestScript
{
    [TestClass]
    public class PhpTravelsTest
    {
        /********************************/
        /********** Demo Page ***********/
        /********************************/
        [TestMethod]
        public void TestFontEndPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // close the pop up form 
            //driver.FindElement(By.XPath("//*[@id='PopupSignupForm_0']/div[2]/div[1]")).Click();
            //Thread.Sleep(2000);

            // Front-end 
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div/div[2]/div/div/div[2]/div[2]/div/div[1]/div/a")).Click();
            Thread.Sleep(4000);

            //driver.FindElement(By.XPath("//*[@id='mobileMenuMain']/nav/ul[2]/li[1]/a")).Click();
            //Thread.Sleep(4000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestBackEndPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Back-end 
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div/div[3]/div/div/div[2]/div[2]/div/div[1]/div/a/small")).Click();
            Thread.Sleep(3000);
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToAppleStore()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Scroll down
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,500);");
            Thread.Sleep(3000);

            // Click on Apple Store logo
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div/div[4]/div/div/div[2]/div[2]/div/div[1]/div/div/a[1]/p/span")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToGooglePlay()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(4000);

            // Scroll down
            IJavaScriptExecutor excutor = driver as IJavaScriptExecutor;
            Thread.Sleep(3000);
            excutor.ExecuteScript("window.scrollBy(0,500);");
            Thread.Sleep(3000);

            // Click on Google Play logo
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div/div[4]/div/div/div[2]/div[2]/div/div[1]/div/div/a[2]/p/span")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCheckDemoPricing()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Check Pricing 
            driver.FindElement(By.XPath("//*[@id='Main']/section[1]/div/div/div[2]/div/div[1]/a/span[1]/b")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        /********************************/
        /**********  Product  ***********/
        /********************************/
        [TestMethod]
        public void TestGoToDocumentation()
        {
            IWebDriver driver = new ChromeDriver();
            Actions actions = new Actions(driver);
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Hover on Product 
            IWebElement product = driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span"));
            //actions.MoveToElement(product);
            product.Click();

            // Click on Documentation  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToProductServices()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on product services 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on integration 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[4]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCustomization()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on customizations //*[@id="main-menu"]/ul/li[3]/div/ul/li[5]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[5]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToApiXmlIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on API XML Integration 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[6]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTestGoToApiXmlIntegration1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on API XML Integration 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[6]/a")).Click();
            Thread.Sleep(3000);

            // Click on DEMO
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div[4]/div[1]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTestGoToApiXmlIntegration2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on API XML Integration 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[6]/a")).Click();
            Thread.Sleep(3000);

            // Click on ORDER NOW 
            driver.FindElement(By.XPath("//*[@id='Main']/section[2]/div/div[4]/div[2]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToSupplierList()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            //click on suppliers list 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[7]/a")).Click();
            Thread.Sleep(3000);
            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToProvider()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            //click on provider 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[8]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTechnology()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on technology 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[9]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToRequirement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on requirements 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[10]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToChangelog()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on changelog 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[11]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToMobileApp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Mobile APP 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[12]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToDesktopApp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Desktop APP
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[13]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToRoadMap()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Road Map 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[14]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToUpdate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Update 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[15]/a")).Click();
            Thread.Sleep(4000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToHowToStart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on How to start
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[16]/a")).Click();
            Thread.Sleep(4000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToMainDocumentation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Main Documentation
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[18]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToInstallation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Installation
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[19]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToProductDownload()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Product Download
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[20]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToObtainLicense()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Obtain License
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[21]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToLanguageManagement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Language Management
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[22]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCurrenciesManagement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Currencies Management
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[23]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToProductFeatures()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Product Features
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[24]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToHotelModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Hotel Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[25]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToFlightModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[26]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTourModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Tour Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[27]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCarModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Car Module 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[28]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToOffersModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Offers Module //*[@id="main-menu"]/ul/li[3]/div/ul/li[29]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[29]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBlogModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Blog Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[30]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToNewsletterModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Newsletter Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[31]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCMSModule()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on CMS Module
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[32]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToFlightBookingEngine()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Booking Engine //*[@id="main-menu"]/ul/li[3]/div/ul/li[34]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[34]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToFlightBookingSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Booking System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[35]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToFlightBookingSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Booking Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[36]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToFlightTicketBooking()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Ticket Booking
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[37]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }


        [TestMethod]
        public void TestGoToFlightTicketReservation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight Ticket Reservation
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[38]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCarRentalSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Car Rental Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[39]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBusBookingSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Bus Booking System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[40]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBookingAgencySoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Booking Agency Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[41]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToOnlineBookingSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Online Booking Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[42]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToArabicTravelSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Arabic Travel System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[43]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToDestinationManagementSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Destination Management System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[44]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToB2BBookingEngine()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on B2B Booking Engine
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[45]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToB2CBookingSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on B2C Booking System 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[46]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelWholesalersSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Wholesalers System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[50]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTourOperatorsSolution()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Tour Operators Solution //*[@id="main-menu"]/ul/li[3]/div/ul/li[51]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[51]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToChannelManagersIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Channel Managers Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[51]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelbranchesSetUp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel branches set-up
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[54]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelAccountingSystemIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Accounting System Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[55]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCustomTravelSolutions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Custom Travel Solutions //*[@id="main-menu"]/ul/li[3]/div/ul/li[57]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[57]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToHotelbedsAPIXMLIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Hotelbeds API XML Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[58]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCartrawlerAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Cartrawler API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[59]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToPKFareAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on PKFare API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[60]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelportAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travelport API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[61]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelportGDSIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travelport GDS Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[62]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToSabreGDSAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Sabre GDS API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[63]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToSabreAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Sabre API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[64]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[65]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToWhatisAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on What is API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[66]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToAPIIntegration()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on API Integration
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[67]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }


        [TestMethod]
        public void TestGoToFlightAPI()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Flight API
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[68]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToB2BHotelBooking()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on B2B Hotel Booking
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[69]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }


        [TestMethod]
        public void TestGoToTravelBookingSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Booking Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[71]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelAPIs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel APIs
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[72]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelManagementSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Management Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[72]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBookingInventorySystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Booking Inventory System //*[@id="main-menu"]/ul/li[3]/div/ul/li[74]/a
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[74]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBookingEngineSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Booking Engine Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[75]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToB2CEnterpriseTravelSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on B2C Enterprise travel software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[76]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToPHPBookingSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on PHP Booking Software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[77]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelCrm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on  Travel Crm
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[78]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelAgencyCrm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Agency Crm
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[79]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelCrmSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Crm Software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[80]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBestTravelCrm()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Best travel Crm 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[81]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCrmForTourOperators()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Crm For Tour Operators 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[82]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }
        [TestMethod]
        public void TestGoToTravelAgencyCrmSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Agency Crm Software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[83]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToBestCrmForTravelAgency()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Best Crm For Travel Agency
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[84]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCrmForTravelIndustry()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Crm For Travel Industry
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[85]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCrmTravelCrmSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Crm Travel Crm System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[86]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTravelCrmOpenSource()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Crm Open Source
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[87]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTourOperatorBookingSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Tour Operator Booking Software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[88]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTourOperatorBookingSoftwareOpenSource()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Tour Operator Booking Software Open Source 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[89]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToItineraryBuildingSoftwareForTourOperators()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Itinerary Building Software For Tour Operators 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[90]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToOnlineTourOperatorSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Online Tour Operator Software 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[91]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }
        [TestMethod]
        public void TestGoToTravelAgentBookingSystem()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Travel Agent Booking System
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[92]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTicketBookingSoftwareForTravelAgents()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Ticket Booking Software For Travel Agents
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[93]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToSabreSoftwareForTravelAgent()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Sabre Software For Travel Agent
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[94]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToItinerarySoftwareForTravelAgents()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Itinerary Software For Travel Agents
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[95]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToSoftwareUsedByTravelAgents()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Software Used By Travel Agents
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[96]/a")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToAmadeusTravelAgentSoftware()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on product 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Amadeus Travel Agent Software
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[3]/div/ul/li[97]/ad")).Click();
            Thread.Sleep(5000);

            // Quite the driver
            driver.Quit();
        }
        /********************************/
        /**********  Hosting  ***********/
        /********************************/
        [TestMethod]
        public void TestGoToSharedHosting()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on hosting 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on shared hosting
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/div/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToVpsHosting()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on hosting 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on VPS Hosting
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToDedicatedServers()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on hosting 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on dedicated servers 
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[4]/div/ul/li[4]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }


        /********************************/
        /**********  Company  ***********/
        /********************************/
        [TestMethod]
        public void TestGoToPublicChat()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Public Chat
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[2]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToContentProgram()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Content Program
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[3]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }


        [TestMethod]
        public void TestGoToAboutUs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on About us
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[4]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToContactUs()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Contact us
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[5]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToPartners()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Partners
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[6]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTheTeam()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on The Team
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[7]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToAffiliate()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Affiliate
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[8]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToMediaKit()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Media Kit
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[9]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToCareers()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Careers/Jobs
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[10]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToPrivacyPolicy()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Privacy Policy
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[11]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        [TestMethod]
        public void TestGoToTermsAndConditions()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Terms & Conditions
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[12]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }
        [TestMethod]
        public void TestGoToForums()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on company  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/span/span")).Click();
            Thread.Sleep(3000);

            // Click on Forums
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[5]/div/ul/li[13]/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        /********************************/
        /************  Blog  ************/
        /********************************/

        [TestMethod]
        public void TestGoToBlog()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on blog  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[6]/span/span/a")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }

        /********************************/
        /************  Login  ***********/
        /********************************/

        [TestMethod]
        public void TestGoToLoginPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://phptravels.com/demo/";
            Thread.Sleep(2000);

            // Maximize screen
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            // Click on Login  
            driver.FindElement(By.XPath("//*[@id='main-menu']/ul/li[7]/a/span")).Click();
            Thread.Sleep(3000);

            // Quite the driver
            driver.Quit();
        }
    }
}