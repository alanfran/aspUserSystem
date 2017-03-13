using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Provides hashing functionality for password handling.
/// </summary>
public class Hashing
{
    private static string GetRandomSalt()
    {
        return BCrypt.Net.BCrypt.GenerateSalt(12);
    }

    public static string HashPassword(string pass)
    {
        return BCrypt.Net.BCrypt.HashPassword(pass, GetRandomSalt());
    }

    public static bool ValidatePassword(string password, string correctHash)
    {
        Console.WriteLine("Comparing: " + password + " to " + correctHash);

        return BCrypt.Net.BCrypt.Verify(password, correctHash);
    }
}