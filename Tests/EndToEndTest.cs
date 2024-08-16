using DemoWebshop.Base;
using DemoWebshop.Configuration;
using DemoWebshop.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Tests
{
    public class EndToEndTest: DemoBase
    {
        public static HomePage homepage;
        public static LoginPage login;
        [Test]
        public void TestHome()
        {
            homepage=new HomePage(driver);
            login=new LoginPage(driver);


            Config config = ConnectData.LoadConfig();

            // Access the login details
            string Email = config.LoginDetails.Email;
            string password = config.LoginDetails.Password;

            //initialising the Login page 
            login = new LoginPage(driver);

            //calling in the Login method and passing passing in login details that are stored in json file
            login.Login(Email, password);
            homepage.Home();
        }
    }
}
