using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Configuration
{
    public class LoginDetails
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class Config
    {
        public LoginDetails LoginDetails { get; set; }
    }

}
