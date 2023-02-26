using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    sealed class Telefon : Komputer
    {
        private uint CamerasCount;
        private string ScreenSize;
        public Telefon(string _CPU, uint _RAM, string _OS, uint _CamerasCount, string _ScreenSize) : base(_CPU, _RAM, _OS)
        {
            this.CamerasCount = _CamerasCount;
            this.ScreenSize = _ScreenSize;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Cameras Count: " + this.CamerasCount);
            Console.WriteLine("Screen Size: " + this.ScreenSize);
        }
        public override void LogIn()
        {
            Console.WriteLine("User has been logged to phone!");
        }
        public override void LogOut()
        {
            Console.WriteLine("User has been logged out from phone!");
        }
        public void ConnectCharger()
        {
            Console.WriteLine("Charger has been connected to phone!");
        }
        public void Call()
        {
            Console.WriteLine("Calling...");
        }
    }
}
