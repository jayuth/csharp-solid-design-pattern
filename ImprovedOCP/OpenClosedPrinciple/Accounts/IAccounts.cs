using System;
namespace OpenClosedPrinciple
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}
