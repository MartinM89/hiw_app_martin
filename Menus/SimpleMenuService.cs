public class SimpleMenuService : IMenuService
{
    Menu menu = new EmptyMenu(null!, "Empty Menu");

    public Menu GetMenu()
    {
        return menu;
    }

    public void SetMenu(Menu menu)
    {
        this.menu = menu;
        menu.Display();
    }

    public void DisplaySameMenu()
    {
        menu.Display();
    }
}

public class EmptyMenu : Menu
{
    public EmptyMenu(GetServices getServices, string title)
        : base(getServices, title) { }
}
