using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Komputer> ComputerList = new List<Komputer>();
            ComputerList.Add(new Komputer("AMD Ryzen 5 3600", 16, "Windows 11"));
            ComputerList.Add(new Komputer("AMD Ryzen 5 5600X", 16, "Windows 10"));
            ComputerList.Add(new Komputer("Intel Core i5-11400F", 16, "Windows 11"));
            List<Laptop> LaptopList = new List<Laptop>();
            LaptopList.Add(new Laptop("Apple M1", 8, "Windows 10", "IPS"));
            LaptopList.Add(new Laptop("AMD Athlon Silver 3050U", 8, "Linux", "IPS"));
            LaptopList.Add(new Laptop("Intel Core i5-11400H", 8,  "Windows 11", "IPS"));
            List<Telefon> TelephoneList = new List<Telefon>();
            TelephoneList.Add(new Telefon("CPU MT6750", 8, "Android", 4, "428x926"));
            TelephoneList.Add(new Telefon("CPU MT6750V", 8, "iOS", 3, "414x896"));
            TelephoneList.Add(new Telefon("MediaTek Dimensity 1200", 8, "BlackBerry OS", 4, "375x667"));

            //Przykładowe działania klas
            ComputerList[1].ShowInformation();
            ComputerList[2].LogIn();
            LaptopList[0].LogOut();
            LaptopList[1].LogIn();
            LaptopList[2].Open();
            TelephoneList[0].Call();
            TelephoneList[1].LogIn();
            TelephoneList[2].ShowInformation();
        }
    }
}