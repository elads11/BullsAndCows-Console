namespace Ex04.Menus.Interfaces
{
    public class ActionOnMenuItem : MenuItem
    {
        private IActionOnMenu m_MenuItemAction;

        public ActionOnMenuItem(string i_MenuName, IActionOnMenu i_MenuItemAction)
            : base(i_MenuName)
        {
            m_MenuItemAction = i_MenuItemAction;
        }

        internal override void ActivateMenuItem()
        {
            m_MenuItemAction.DoActionOnMenu();
        }
    }
}
