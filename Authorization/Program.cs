using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Authorization
{

    internal class Register
    {
        static void Main(string[] args)
        {
            Login log = new Login();
            var actual = Login.CheckRegister("yekatod123_", "Абоба111", "Абоба112"); ;
            Console.WriteLine(actual.Item1 + " " + actual.Item2);
            Console.ReadKey();
        }
    }
}

