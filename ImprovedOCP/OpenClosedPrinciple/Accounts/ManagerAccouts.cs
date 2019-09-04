using System;
namespace OpenClosedPrinciple
{
    public class ManagerAccouts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{ person.FirstName.Substring(0, 1) }{ person.LastName}@manager.com";

            output.IsManager = true;

            return output;
        }
    }
}
