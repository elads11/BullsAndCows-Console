namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuOrganizer
    {
        public MainMenu(string i_MenuName)
            : base(i_MenuName)
        {  
        }

        public void Show()
        {
            ActivateMenuItem();
        }
    }
}
