using System.Text.RegularExpressions;

public class RegisterAdminCommand : Command
{
    private static string[] questions =
    [
        "\nEnter email: ",
        "\nEnter first name: ",
        "\nEnter surname: ",
        "\nEnter adress: ",
        "\nEnter city: ",
        "\nEnter zipcode: ",
        "\nEnter country: ",
        "\nEnter social security number: ",
        "\nEnter password: ",
        "\nVerify password: ",
    ];

    private static string[] answers = new string[questions.Length];

    public RegisterAdminCommand(GetServices getServices)
        : base(
            "9",
            "Register-admin",
            "Hidden register command for super admin to register new admins.",
            false,
            getServices
        ) { }

    public override void Execute(string[] input)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Enter super password: ");
            string? superPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(superPassword))
            {
                Console.WriteLine("\nPassword can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (superPassword.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            bool verifyPassword = SuperAdminVerification(superPassword);

            if (!verifyPassword)
            {
                Console.WriteLine("\nPassword did not match!");
                Helper.PressKeyToContinue();
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[0]);

            string? email = Console.ReadLine();
            email = email?.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("\nEmail can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (email.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Console.WriteLine("\nInvalid email format.");
                Helper.PressKeyToContinue();
                continue;
            }

            answers[0] = email;

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[1]);

            string? firstName = Console.ReadLine();
            firstName = firstName?.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                Console.WriteLine("\nFirst name can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (firstName.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!firstName.All(char.IsLetter))
            {
                Console.WriteLine("\nName can only contain letters.");
                Helper.PressKeyToContinue();
                continue;
            }

            answers[1] = StringHelper.CapitilazeFirstLetter(firstName);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[2]);

            string? surname = Console.ReadLine();
            surname = surname?.Trim();

            if (string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("\nSurname can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (surname.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!surname.All(char.IsLetter))
            {
                Console.WriteLine("\nSurname can only contain letters.");
                Helper.PressKeyToContinue();
                continue;
            }

            answers[2] = StringHelper.CapitilazeFirstLetter(surname);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[3]);

            string? adress = Console.ReadLine();
            adress = adress?.Trim();

            if (string.IsNullOrWhiteSpace(adress))
            {
                Console.WriteLine("\nAdress can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (adress.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            answers[3] = Helper.CheckForAdressFormat(adress);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[4]);

            string? city = Console.ReadLine();
            city = city?.Trim();

            if (string.IsNullOrWhiteSpace(city))
            {
                Console.WriteLine("\nCity can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (city.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!city.All(char.IsLetter))
            {
                Console.WriteLine("\nCity can only contain letters.");
                Helper.PressKeyToContinue();
                continue;
            }

            answers[4] = StringHelper.CapitilazeFirstLetter(city);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[5]);

            string? zipCode = Console.ReadLine();
            zipCode = zipCode?.Trim();

            if (string.IsNullOrWhiteSpace(zipCode))
            {
                Console.WriteLine("\nZip code can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (zipCode.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            answers[5] = Helper.CheckForZipCodeFormat(zipCode);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[6]);

            string? country = Console.ReadLine();
            country = country?.Trim();

            if (string.IsNullOrWhiteSpace(country))
            {
                Console.WriteLine("\nCountry can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (country.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!country.All(char.IsLetter))
            {
                Console.WriteLine("\nCountry can only contain letters.");
                Helper.PressKeyToContinue();
                continue;
            }

            answers[6] = StringHelper.CapitilazeFirstLetter(country);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[7]);

            string? socialSecurityNumber = Console.ReadLine();
            socialSecurityNumber = socialSecurityNumber?.Trim();

            if (string.IsNullOrWhiteSpace(socialSecurityNumber))
            {
                Console.WriteLine("\nSocial security number can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (socialSecurityNumber.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            answers[7] = Helper.CheckForSocialSecurityNumberFormat(socialSecurityNumber);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[8]);

            string? password = StringHelper.HidePassword();
            password = password?.Trim();

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("\nPassword can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (password.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            answers[8] = Helper.CheckPasswordStrength(password);

            break;
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:\n");
            Console.Write(questions[9]);

            string? verifyPassword = StringHelper.HidePassword();
            verifyPassword = verifyPassword?.Trim();

            if (string.IsNullOrWhiteSpace(verifyPassword))
            {
                Console.WriteLine("\nPassword can't be empty.");
                Helper.PressKeyToContinue();
                continue;
            }

            if (verifyPassword.ToLower().Equals("exit"))
            {
                GetServices.MenuService.DisplaySameMenu();
                return;
            }

            if (!answers[8].Equals(verifyPassword))
            {
                Console.WriteLine("\nPasswords did not match.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        User user =
            new()
            {
                Email = answers[0],
                FirstName = answers[1],
                Surname = answers[2],
                Adress = answers[3],
                City = answers[4],
                ZipCode = answers[5],
                Country = answers[6],
                SocialSecurityNumber = answers[7],
                PasswordHash = answers[8],
                IsAdmin = true,
            };

        GetServices.AccountService.Register(user);

        Console.WriteLine("\nAdmin account successfully registered.");
        Console.ReadKey();

        GetServices.MenuService.DisplaySameMenu();
        return;
    }

    public bool SuperAdminVerification(string superPassword)
    {
        // Super password = '12345'
        string superAdminPasswordcHashed =
            "$2a$11$c6im/N.iMNgnk1StV26EHO3AAoXXCauJf9QhHqu1DSNg3iWNNt4Rq";

        return BCrypt.Net.BCrypt.EnhancedVerify(superPassword, superAdminPasswordcHashed);
    }
}
