using System;
namespace SingleResponsibilityPrinciple
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // create a username account for the person
            Console.WriteLine($"Your username is { user.FirstName.Substring(0,1)}{user.LastName}");
        }
    }
}
