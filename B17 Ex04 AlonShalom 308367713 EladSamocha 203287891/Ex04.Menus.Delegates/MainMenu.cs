namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuOrginizer
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
