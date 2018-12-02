using System;

namespace Ex04.Menus.Test
{
    public class InterfacesMenu
    {
        public static void RunInterfaces()
        {
            Interfaces.MainMenu interfaceForMainMenu = new Interfaces.MainMenu("Interface Main Menu");
            Interfaces.ActionOnMenuItem interfaceForVersion = new Interfaces.ActionOnMenuItem("Display Version", new VersionDisplayer());
            Interfaces.MenuOrganizer interfaceForActionsAndInfo = new Interfaces.MenuOrganizer("Actions and Info");            
            Interfaces.MenuOrganizer interfaceForActions = new Interfaces.MenuOrganizer("Actions");
            Interfaces.ActionOnMenuItem interfaceForSpacesCount = new Interfaces.ActionOnMenuItem("Count Spaces", new SpacesCounter());
            Interfaces.ActionOnMenuItem interfaceForCharsCount = new Interfaces.ActionOnMenuItem("Chars Count", new CharsCounter());
            Interfaces.MenuOrganizer interfaceForDateAndTime = new Interfaces.MenuOrganizer("Show Date/Time");
            Interfaces.ActionOnMenuItem interfaceForTime = new Interfaces.ActionOnMenuItem("Show Time", new TimeDisplayer());
            Interfaces.ActionOnMenuItem interfaceForDate = new Interfaces.ActionOnMenuItem("Show Date", new DateDisplayer());

            interfaceForMainMenu.AddNewMenuItem(interfaceForActionsAndInfo);
            interfaceForMainMenu.AddNewMenuItem(interfaceForDateAndTime);
            interfaceForActionsAndInfo.AddNewMenuItem(interfaceForVersion);
            interfaceForActionsAndInfo.AddNewMenuItem(interfaceForActions);            
            interfaceForActions.AddNewMenuItem(interfaceForSpacesCount);
            interfaceForActions.AddNewMenuItem(interfaceForCharsCount);
            interfaceForDateAndTime.AddNewMenuItem(interfaceForTime);
            interfaceForDateAndTime.AddNewMenuItem(interfaceForDate);            

            interfaceForMainMenu.Show();
        }

        public class VersionDisplayer : Interfaces.IActionOnMenu
        {
            public void DoActionOnMenu()
            {
                DisplayVersion();
            }

            public void DisplayVersion()
            {
                Console.WriteLine("App Version: 17.2.4.0");
            }
        }
    }
}
