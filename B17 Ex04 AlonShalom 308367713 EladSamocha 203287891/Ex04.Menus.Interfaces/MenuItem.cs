namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly string r_MenuName;

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
        }
    }
}