using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class MenuOrginizer : MenuItem
    {
        private static int s_MenuLevel;
        private readonly List<MenuItem> r_MenuList = new List<MenuItem>();

        public MenuOrginizer(string i_MenuName)
            : base(i_MenuName)
        {
            s_MenuLevel = -1;
        }

        internal override void ActivateMenuItem()
        {
            int numberOfShownMenu;
            s_MenuLevel++;
            if (r_MenuList != null)
            {
                do
                {
                    numberOfShownMenu = 0;
                    Console.WriteLine("{0}", r_MenuName);
                    foreach (MenuItem CurrentMenu in r_MenuList)
                    {
                        numberOfShownMenu++;
                        Console.WriteLine("{0} {1}", numberOfShownMenu, CurrentMenu.MenuName);
                    }
                }
                while (!getValidInputFromUser());
                Console.Clear();
            }
        }

        private bool getValidInputFromUser()
        {
            // $G$ CSS-999 (-3) bool template should be written like this - isXXX at the beginning.
            bool validInput = true;
            bool backOrExit = false;
            string inputMenuFromUser;
            int inputMenuFromUserToInt;

            if (s_MenuLevel == 0)
            {
                Console.WriteLine("0 Exit");
            }
            else
            {
                Console.WriteLine("0 Back");
            }

            do
            {                
                Console.WriteLine("please choose between 0 to {0}:", r_MenuList.Count);
                inputMenuFromUser = Console.ReadLine();
                if (!(validInput = int.TryParse(inputMenuFromUser, out inputMenuFromUserToInt)))
                {
                    Console.WriteLine("invalid input!");
                }
                else
                {
                    if (!(inputMenuFromUserToInt >= 0 && inputMenuFromUserToInt <= r_MenuList.Count))
                    {
                        Console.WriteLine("wrong input! not in the correct range!");
                        validInput = false;
                    }
                }
            }
            while (!validInput);
            if (inputMenuFromUserToInt == 0)
            {
                s_MenuLevel--;
                backOrExit = true;
            }
            else
            {
                Console.Clear();
                r_MenuList[inputMenuFromUserToInt - 1].ActivateMenuItem();
            }

            return backOrExit;
        }

        public void AddNewMenuItem(MenuItem i_MenuItemToAdd)
        {
            r_MenuList.Add(i_MenuItemToAdd);
        }
    }
}