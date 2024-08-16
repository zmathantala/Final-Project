using DemoWebshop.Selectors;
using DemoWebshop.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DemoWebshop.Pages
{
    public class LoginPage
    {
        public static IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
           LoginPage.driver = driver;
        }
        IWebElement Loginink => driver.FindElement(LoginSelectors.loginLink);
        IWebElement Email => driver.FindElement(LoginSelectors.Email);
        IWebElement Password => driver.FindElement(LoginSelectors.Passowrd);
        IWebElement LoginButton => driver.FindElement(LoginSelectors.LoginButton);
        IWebElement LoginHeading => driver.FindElement(LoginSelectors.Heading);
        public void Login(string email, string password)
        {
          
            Utils.CLICK(Loginink);

            bool isDisplayed = Utils.IsElementDisplayed1(LoginHeading);
            Console.WriteLine($"Element displayed: {isDisplayed}");

            Utils.EnterText(Email, email);
            Utils.EnterText(Password, password);
            Utils.SubmitButton(LoginButton);

            
        }
    }
}
