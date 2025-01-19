public class RegisterAdminCommand : Command
{
    private static readonly string[] questions =
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

    private static readonly string[] answers = new string[questions.Length];

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
        // Super password
        while (true)
        {
            Console.Clear();
            Console.Write("Enter super password: ");
            string? superPassword = StringHelper.HidePassword();

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

        // Email
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.Write(questions[0]);

            string? email = Console.ReadLine();
            email = email?.Trim().ToLower();

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

            if (GetServices.AccountService.CheckUsernameAlreadyUsed(email))
            {
                Console.WriteLine("\nEmail already in use.");
                Helper.PressKeyToContinue();
                continue;
            }

            try
            {
                answers[0] = Helper.CheckForEmailFormat(email);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid email format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // First name
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(questions[0] + answers[0]);
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

            try
            {
                answers[1] = StringHelper.CapitilazeFirstLetter(firstName);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid first name format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Surname
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(questions[0] + answers[0] + questions[1] + answers[1]);
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

            try
            {
                answers[2] = StringHelper.CapitilazeFirstLetter(surname);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid surname format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Adress
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0] + answers[0] + questions[1] + answers[1] + questions[2] + answers[2]
            );
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

            try
            {
                answers[3] = Helper.CheckForAdressFormat(adress);
            }
            catch (Exception)
            {
                Console.WriteLine(
                    "\nInvalid address format. The address must contain a street name followed by a space and a number."
                );
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // City
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
            );
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

            try
            {
                answers[4] = StringHelper.CapitilazeFirstLetter(city);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid city format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Zip code
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
                    + questions[4]
                    + answers[4]
            );
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

            try
            {
                answers[5] = Helper.CheckForZipCodeFormat(zipCode);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid zip code format. The zip code must contain 5 digits.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Country
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
                    + questions[4]
                    + answers[4]
                    + questions[5]
                    + answers[5]
            );
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

            try
            {
                answers[6] = StringHelper.CapitilazeFirstLetter(country);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid country format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Social security number
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
                    + questions[4]
                    + answers[4]
                    + questions[5]
                    + answers[5]
                    + questions[6]
                    + answers[6]
            );
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

            try
            {
                answers[7] = Helper.CheckForSocialSecurityNumberFormat(socialSecurityNumber);
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid social security number format.");
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Password
        string? password;
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
                    + questions[4]
                    + answers[4]
                    + questions[5]
                    + answers[5]
                    + questions[6]
                    + answers[6]
                    + questions[7]
                    + answers[7]
            );
            Console.Write(questions[8]);

            password = StringHelper.HidePassword();
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

            try
            {
                answers[8] = Helper.CheckPasswordStrength(password);
            }
            catch (Exception)
            {
                Console.WriteLine(
                    "\nPassword must contain at least 8 characters, one uppercase letter, one lowercase letter, one number and one special character."
                );
                Helper.PressKeyToContinue();
                continue;
            }

            break;
        }

        // Verify password
        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Admin registration menu:");
            Console.WriteLine(
                questions[0]
                    + answers[0]
                    + questions[1]
                    + answers[1]
                    + questions[2]
                    + answers[2]
                    + questions[3]
                    + answers[3]
                    + questions[4]
                    + answers[4]
                    + questions[5]
                    + answers[5]
                    + questions[6]
                    + answers[6]
                    + questions[7]
                    + answers[7]
                    + questions[8]
                    + answers[8].Replace(answers[8], new string('*', answers[8].Length))
            );
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

            if (!password.Equals(verifyPassword))
            {
                Console.WriteLine("\nPasswords did not match.");
                Helper.PressKeyToContinue();
                continue;
            }

            password = Helper.SaltAndHashPassword(password);

            break;
        }

        User admin =
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
                PasswordHash = password,
                IsAdmin = true,
            };

        GetServices.AccountService.Register(admin);

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
