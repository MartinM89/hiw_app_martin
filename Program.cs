class Program
{
    static void Main(string[] commandArgs)
    {
        DatabaseHelper.GetString();

        GetServices getServices = new();

        getServices.MenuService.SetMenu(new LoginMenu(getServices));

        while (true)
        {
            Console.Clear();
            getServices.MenuService.DisplaySameMenu();

            string? input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                getServices.MenuService.GetMenu().RunCommand(input);
                continue;
            }

            Console.Clear();
            Console.WriteLine("Choice can't be empty.");
            Helper.PressKeyToContinue();
        }
    }
}
