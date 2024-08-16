using DemoWebshop.Selectors;
using DemoWebshop.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Pages
{
    public class HomePage
    {
        public static IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }
        IWebElement UserEmail => driver.FindElement(HomeLocators.UserEmail);
        IWebElement Jewelry => driver.FindElement(HomeLocators.jewelry);

        IWebElement View => driver.FindElement(HomeLocators.View);

        IWebElement Create => driver.FindElement(HomeLocators.Create);

        IWebElement Length => driver.FindElement(HomeLocators.Length);

        IWebElement Heart => driver.FindElement(HomeLocators.Heart);

        IWebElement Country => driver.FindElement(HomeLocators.Country);

        IWebElement Quality => driver.FindElement(HomeLocators.Quality);

        IWebElement Code => driver.FindElement(HomeLocators.Code);

        IWebElement ShoppingCart => driver.FindElement(HomeLocators.ShoppingCart);

        IWebElement AddToCart => driver.FindElement(HomeLocators.AddToCart);

        IWebElement TC => driver.FindElement(HomeLocators.TC);

        IWebElement Logo => driver.FindElement(HomeLocators.Logo);

        IWebElement Logout => driver.FindElement(HomeLocators.Logout);
        IWebElement Checkout => driver.FindElement(HomeLocators.Checkout);
        IWebElement SelectMaterial => driver.FindElement(HomeLocators.SelectMaterial);
        string JewelyURL = "https://demowebshop.tricentis.com/jewelry";

        public void Home()
        {
            //Verify user email is displayed in page header
            bool isDisplayed = Utils.IsElementDisplayed1(UserEmail);
            Console.WriteLine($"Element displayed: {isDisplayed}");

            //Select Jewelry
            Utils.CLICK(Jewelry);

            // Verify if the URL contains "jewelry"
            if (driver.Url.Contains("jewelry"))
            {
                Console.WriteLine("URL contains 'jewelry'");
            }
            else
            {
                Console.WriteLine("URL does not contain 'jewelry'");
            }

            //Select List under the View as dropdown
            Utils.SelectValueByIndex(View, 1);

            //Click on the product labled Create Your Own Jewelry image 
            Utils.CLICK(Create);

            //Select Gold (1mm) from the Material dropdown 
            Utils.SelectValueByIndex(SelectMaterial, 1);

            //Enter 30 into the Length in cm source field
            Utils.EnterText(Length, "30");

            //Select the Heart radio button under Pendant
            Utils.CLICK(Heart);

            //Encrease Quantity to 2 
            Utils.EnterText(Quality, "2");

            //Click on the Add to cart button 
            Utils.CLICK(AddToCart);

            //Click on the   Shopping Cart Link in the header
            Utils.CLICK(ShoppingCart);

            //Click on the Country dropdown and Select American Samoa on the dropdown 

            Utils.SelectValueByIndex(Country, 6);

            //Insert 96799 into the zipcode source field
            Utils.EnterText(Code, "96799");

            //Select th Agree to TC & C checkbox
            Utils.CLICK(TC);

            //Click on the Checkout button
            Utils.CLICK(Checkout);

            //Verify that the page header is Checkout

            if (driver.Title.Contains("Checkout"))
            {
                Console.WriteLine("title contains 'Checkout'");
            }
            else
            {
                Console.WriteLine("title does not contain 'Checkout'");
            }

            //Click on the Demo Work Shop Logo
            Utils.CLICK(Logo);

            //Select on the Logout in the header
            Utils.CLICK(Logout);
        }
    }
}
