using System.Text.RegularExpressions;

public class Helper
{
    public static void PressKeyToContinue()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(false);
    }

    public static string CheckForAdressFormat(string input)
    {
        input = StringHelper.CapitilazeFirstLetter(input);

        input = Regex.Replace(input, @"(\D)\s*(\d)", "$1 $2");

        Console.WriteLine(input);
        PressKeyToContinue();

        if (
            Regex.IsMatch(input, @"^[A-Za-zåäöÅÄÖ]+\s\d+[A-Za-zåäöÅÄÖ]?$")
            || Regex.IsMatch(input, @"^[A-Za-zåäöÅÄÖ]+\s\d+$")
        )
        {
            Console.WriteLine(input);
            PressKeyToContinue();
            return input;
        }
        else
        {
            Console.WriteLine(input);
            PressKeyToContinue();
            throw new FormatException(
                "Invalid address format. The address must contain a street name followed by a space and a number."
            );
        }
    }

    public static string CheckForZipCodeFormat(string input)
    {
        if (Regex.IsMatch(input, @"^\d{5}$"))
        {
            return input[..3] + " " + input[3..];
        }
        else
        {
            throw new FormatException(
                "Invalid zip code format. The zip code must contain 5 digits."
            );
        }
    }

    public static string CheckForSocialSecurityNumberFormat(string input)
    {
        input = Regex.Replace(input, @"\D", "");

        if (input.Length == 10)
        {
            if (Regex.IsMatch(input, @"^\d{2}\d{2}\d{2}\d{4}$"))
            {
                return input[..2] + "-" + input[2..4] + "-" + input[4..6] + "-" + input[6..];
            }
            else
            {
                throw new FormatException(
                    "Invalid social security number format. The format must be YY-MM-DD-NNNN."
                );
            }
        }
        else if (input.Length == 12)
        {
            if (Regex.IsMatch(input, @"^\d{4}\d{2}\d{2}\d{4}$"))
            {
                return input[..4] + "-" + input[4..6] + "-" + input[6..8] + "-" + input[8..];
            }
            else
            {
                throw new FormatException(
                    "Invalid social security number format. The format must be YYYY-MM-DD-NNNN."
                );
            }
        }
        else
        {
            throw new FormatException(
                "Invalid social security number format. The number must contain 10 or 12 digits."
            );
        }
    }

    public static string CheckPasswordStrength(string input)
    {
        if (input.Length < 4)
        {
            throw new FormatException("Password must be at least 8 characters long.");
        }

        if (!Regex.IsMatch(input, @"[a-z]"))
        {
            throw new FormatException("Password must contain at least one lowercase letter.");
        }

        if (!Regex.IsMatch(input, @"[A-Z]"))
        {
            throw new FormatException("Password must contain at least one uppercase letter.");
        }

        if (!Regex.IsMatch(input, @"[0-9]"))
        {
            throw new FormatException("Password must contain at least one digit.");
        }

        if (!Regex.IsMatch(input, @"[!@#$%^&*()_+}{:;?.><,]"))
        {
            throw new FormatException("Password must contain at least one special character.");
        }

        return input;
    }
}
