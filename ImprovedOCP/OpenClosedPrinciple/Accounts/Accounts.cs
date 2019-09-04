using System;
namespace OpenClosedPrinciple
{
    public class Accounts : IAccounts
    {
        // convert a person object to an employee object
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName}@mycompany.com";

            return output;
        }
    }
}
