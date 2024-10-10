using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Przyklad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lekcja programowania");

            string wartosc_parametru;

            var Ini = new ConfigFile(@".\Config.ini");

            wartosc_parametru = Ini.Read("ipaddress", "Drukarka");
            Console.WriteLine("IP address: " + wartosc_parametru);

            wartosc_parametru = Ini.Read("port", "Drukarka");
            Console.WriteLine("port: " + wartosc_parametru);

            Console.ReadLine();
        }
  
    }
}
