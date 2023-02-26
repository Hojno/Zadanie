using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
    {
        public class Komputer
        {
            protected string CPU;
            protected uint RAM;
            protected string OS;

            public Komputer(string _CPU, uint _RAM, string _OS)
            {
                this.CPU = _CPU;
                this.RAM = _RAM;
                this.OS = _OS;
            }
            public virtual void ShowInformation()
            {
                Console.WriteLine("CPU: " + this.CPU);
                Console.WriteLine("RAM: " + this.RAM);
                Console.WriteLine("OS: " + this.OS);
            }
            public virtual void LogIn()
            {
                Console.WriteLine("User has been logged to computer!");
            }
            public virtual void LogOut()
            {
                Console.WriteLine("User has been logged out from computer!");
            }

            public void InstallProgram()
            {
                Console.WriteLine("Program has been installed!");
            }
        }
    }


