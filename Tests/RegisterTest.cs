using DemoWebshop.Base;
using DemoWebshop.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebshop.Tests
{
    public  class RegisterTest:DemoBase
    {
        public static RegisterPage register;
        [Test]
        public void Registering()
        {
            register=new RegisterPage(driver);
            register.Register("Zizipho", "Matantala","zmathantala@gmail.com","Zizipho105!", "Zizipho105!");
        }
    }
}
