using System;
namespace OpenClosedPrinciple
{
    public class ManagerModel : IApplicantModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IAccounts AccountProcessor { get; set; } = new ManagerAccouts();
    }
}
