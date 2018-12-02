using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{  
    public class DateDisplayer : IActionOnMenu
    {
        public void DoActionOnMenu()
        {
            ShowDate();
        }

        public void ShowDate()
        {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString("d"));
        }
    }
}
