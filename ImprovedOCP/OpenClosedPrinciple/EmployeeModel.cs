using System;
namespace OpenClosedPrinciple
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        // extension - minor change
        public bool IsManager { get; set; } = false;

        public bool IsExecutive { get; set; } = false;
    }
}
