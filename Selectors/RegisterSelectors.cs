using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Selectors
{
    public class RegisterSelectors
    {
        public static By RegisterLink = (By.XPath("//a[contains(.,'Register')]"));
        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By genderFemale = By.Id("gender-female");


        public static readonly By firstName = By.Id("FirstName");
        public static readonly By lastName = By.Id("LastName");
        public static readonly By email = By.Id("Email");
        public static readonly By password = By.Id("Password");
        public static readonly By confirmPassword = By.Id("ConfirmPassword");
        public static readonly By RegisterButton = By.Name("register-button");
    }
}
