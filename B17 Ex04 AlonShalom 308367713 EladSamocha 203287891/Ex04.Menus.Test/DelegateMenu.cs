using System;

namespace Ex04.Menus.Test
{
    internal class DelegateMenu
    {
        public static void RunDelegate()
        {
            Delegates.MainMenu delegateForMainMenu = new Delegates.MainMenu("Delegate Main menu");
            Delegates.MenuOrginizer delegateForActionsAndInfo = new Delegates.MenuOrginizer("Actions and Info");
            Delegates.MenuOrginizer delegateForActions = new Delegates.MenuOrginizer("Actions");
            Delegates.MenuOrginizer delegateForDateAndTime = new Delegates.MenuOrginizer("Show Date/Time");
            Delegates.MenuItem delegateOfDisplayVersion = new Delegates.MenuItem("version");
            Delegates.MenuItem delegateOfSpaceCount = new Delegates.MenuItem("Count Spaces");
            Delegates.MenuItem delegateOfCharsCount = new Delegates.MenuItem("Chars Count");
            Delegates.MenuItem delegateForTime = new Delegates.MenuItem("Show Time");
            Delegates.MenuItem delegateForDate = new Delegates.MenuItem("Show Date");

            delegateOfDisplayVersion.MenuItemAction += DisplayVersion;
            delegateOfSpaceCount.MenuItemAction += DelegateApplication.CountSpacesInInput;
            delegateOfCharsCount.MenuItemAction += DelegateApplication.CountCharsInInput;
            delegateForTime.MenuItemAction += DelegateApplication.ShowTime;
            delegateForDate.MenuItemAction += DelegateApplication.ShowDate;

            delegateForMainMenu.AddNewMenuItem(delegateForActionsAndInfo);
            delegateForMainMenu.AddNewMenuItem(delegateForDateAndTime);
            delegateForActionsAndInfo.AddNewMenuItem(delegateOfDisplayVersion);
            delegateForActionsAndInfo.AddNewMenuItem(delegateForActions);
            delegateForActions.AddNewMenuItem(delegateOfSpaceCount);
            delegateForActions.AddNewMenuItem(delegateOfCharsCount);
            delegateForDateAndTime.AddNewMenuItem(delegateForTime);
            delegateForDateAndTime.AddNewMenuItem(delegateForDate);

            delegateForMainMenu.Show();
        }

        public static void DisplayVersion()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }
    }
}
