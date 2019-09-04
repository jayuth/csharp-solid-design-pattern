using System;
namespace OpenClosedPrinciple
{
    public class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // extension
        public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
    }
}
