public class LoginUserCommand : Command
{
    public LoginUserCommand(GetServices getServices)
        : base("2", "Login", "Login registered user.", true, getServices) { }

    public override void Execute(string[] input)
    {
        Console.Clear();
        if (!GetServices.AccountService.CheckIfAnyAccountExists())
        {
            Console.WriteLine("No accounts found. Please register an account first.");
            Helper.PressKeyToContinue();
            GetServices.MenuService.DisplaySameMenu();
            return;
        }

        string? username;

        while (true)
        {
            Console.Clear();
            Console.Write("Username: ");
            username = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username cannot be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (username.Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!GetServices.AccountService.CheckUsernameAlreadyUsed(username))
            {
                Console.WriteLine("Username not found.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Username: " + username);
            Console.Write("Password: ");
            string? password = StringHelper.HidePassword();

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Password cannot be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (password.Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            try
            {
                GetServices.AccountService.Login(username, password);
                Console.Clear();
                Console.WriteLine("Login successful.");
                Helper.PressKeyToContinue();
                GetServices.MenuService.SetMenu(new ProductMenu(GetServices));
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(password);
                Console.WriteLine("\n" + e.Message);
                Helper.PressKeyToContinue();
            }
        }
    }
}
