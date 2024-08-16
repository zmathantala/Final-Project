using DemoWebshop.Base;
using DemoWebshop.Configuration;
using DemoWebshop.Pages;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Tests
{
    public class LoginTest:DemoBase
    {
        public static LoginPage loginOBJ;
       
        [Test]
        public void LoginTests()
        {
            // Read and deserialize the JSON configuration file
            Config config = ConnectData.LoadConfig();

            // Access the login details
            string Email = config.LoginDetails.Email;
            string password = config.LoginDetails.Password;

            //initialising the Login page 
            loginOBJ =new LoginPage(driver);

            //calling in the Login method and passing passing in login details that are stored in json file
            loginOBJ.Login(Email, password);

        }
    }
}
