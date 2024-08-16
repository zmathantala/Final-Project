using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Configuration
{
    //Define C# classes to map the JSON structure. 
    public class LoginDetails
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
    // Create a Config class that mirrors the structure of your config.json.
    public class Config
    {
        public LoginDetails LoginDetails { get; set; }
    }
   

}
