namespace Ex04.Menus.Delegates
{
    public delegate void ActionOnMenu();

    public class MenuItem
    {
        // $G$ CSS-021 (-3) Event name should end with the extension of "EventHandler"
        public event ActionOnMenu MenuItemAction;

        protected readonly string r_MenuName;

        public MenuItem(string i_MenuName)
        {
            r_MenuName = i_MenuName;
        }
        
        public string MenuName
        {
            get { return r_MenuName; }
        }

        internal virtual void ActivateMenuItem()
        {
            if (MenuItemAction != null)
            {
                MenuItemAction.Invoke();
            }
        }
    }
}