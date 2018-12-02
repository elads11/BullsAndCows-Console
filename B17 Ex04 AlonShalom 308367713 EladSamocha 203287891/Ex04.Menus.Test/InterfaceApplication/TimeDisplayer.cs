using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TimeDisplayer : IActionOnMenu
    {
        public void DoActionOnMenu()
        {
            ShowTime();
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
        }
    }
}
