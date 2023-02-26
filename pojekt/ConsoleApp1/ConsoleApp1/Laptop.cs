using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zadanie
{
    sealed class Laptop : Komputer
    {
        private string MatrixType;
        public Laptop(string _CPU, uint _RAM, string _OS, string _MatrixType) : base(_CPU, _RAM, _OS)
        {
            this.MatrixType = _MatrixType;
        }

        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("MatrixType: " + this.MatrixType);
        }
        public override void LogIn()
        {
            Console.WriteLine("User has been logged to laptop!");
        }
        public override void LogOut()
        {
            Console.WriteLine("User has been logged out from laptop!");
        }
        public void Open()
        {
            Console.WriteLine("Laptop has been opened!");
        }
    }
}
