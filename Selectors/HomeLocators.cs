using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Selectors
{
    public  class HomeLocators
    {
        //a[contains(.,'zmathantala@gmail.com')]
        public static readonly By UserEmail = By.XPath("//a[contains(.,'zmathantala@gmail.com')]");
        public static readonly By View = By.XPath("//select[@id='products-viewmode']");
        public static readonly By jewelry = By.LinkText("Jewelry");
      //  public static readonly By Create = By.XPath("//a[contains(.,'Create Your Own Jewelry')]");

        public static readonly By Create = By.LinkText("Create Your Own Jewelry");
        public static readonly By SelectMaterial = By.XPath("//select[@id='product_attribute_71_9_15']");
        public static readonly By Length = By.XPath("//input[@name='product_attribute_71_10_16']");
        public static readonly By Heart = By.XPath("//input[@id='product_attribute_71_11_17_49']");
        public static readonly By Quality = By.XPath("//input[@id='addtocart_71_EnteredQuantity']");
        public static readonly By AddToCart = By.XPath("//input[@class='button-1 add-to-cart-button']");
        public static readonly By ShoppingCart = By.XPath("//span[contains(.,'Shopping cart')]");
        public static readonly By Country = By.Id("CountryId");
        public static readonly By Code = By.Id("ZipPostalCode");
        public static readonly By TC = By.Id("termsofservice");
        public static readonly By Checkout = By.Id("checkout");
        public static readonly By Logo = By.XPath("//img[@alt='Tricentis Demo Web Shop']");
        public static readonly By Logout = By.XPath("//a[contains(@href,'/logout')]");
       






        //input[@id='product_attribute_71_11_17_49']



    }
}
