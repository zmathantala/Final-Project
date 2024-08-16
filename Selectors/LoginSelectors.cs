using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Selectors
{
    public  class LoginSelectors
    {
        public static readonly By Heading = By.XPath("//div[@class='title']/strong [text()='Returning Customer']");
        public static readonly By LoginButton = By.XPath("//input[@class='button-1 login-button']");

        public static readonly By Passowrd = By.XPath("//input[contains(@id,'Password')]");
        public static readonly By loginLink = By.XPath("//a[contains(.,'Log in')]");
        public static readonly By Email= By.XPath("//input[contains(@id,'Email')]");
        
    }
}
