using DemoWebshop.Selectors;
using DemoWebshop.Utility;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Pages
{
    public  class RegisterPage
    {
        public static IWebDriver driver;

        public RegisterPage(IWebDriver driver) {
            RegisterPage.driver = driver; 
        }
        IWebElement RegisterLink => driver.FindElement(RegisterSelectors.RegisterLink);
        IWebElement RadioFemale => driver.FindElement(RegisterSelectors.genderFemale);
        IWebElement FirstNmae => driver.FindElement(RegisterSelectors.firstName);
        IWebElement LastNmae => driver.FindElement(RegisterSelectors.lastName);
        IWebElement Email => driver.FindElement(RegisterSelectors.email);
        IWebElement Password => driver.FindElement(RegisterSelectors.password);
        IWebElement ConfirmPassword => driver.FindElement(RegisterSelectors.confirmPassword);
        IWebElement RegisterButton => driver.FindElement(RegisterSelectors.RegisterButton);

        public void Register(string name, string surname, string email, string password, string confirmPassword)
        {
            Utils.CLICK(RegisterLink);
            Utils.EnterText(FirstNmae, name);
            Utils.EnterText(LastNmae, surname);
            Utils.EnterText(Email, email);
            Utils.EnterText(Password, password);
            Utils.EnterText(ConfirmPassword, confirmPassword);
            Utils.SubmitButton(RegisterButton);

        }

    }
}
