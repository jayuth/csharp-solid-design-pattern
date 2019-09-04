using System;
using System.Collections.Generic;

// goal of OCP - object should be open for extension but not for modification
// this program introduces many changes as the user requires new features.
// e.g. adding new types of employees will introduce changes as follows:
// adding a new class Enums to stroe types of employees, changes in logic of EmployeeModel, PersonModel, Accounts, and Program classes.
// these changes viloate the OCP priciple 
namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel{ FirstName = "Teerapong", LastName = "Uthairat" },
                new PersonModel{ FirstName = "Lisa", LastName = "Wong", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel{ FirstName = "Stacy", LastName = "Yao", TypeOfEmployee = EmployeeType.Executive }
            };

            // create an empty list of employees to store employee objects later
            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                // add a new employee object to the list
                // convert a person object to an employee object
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress} IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive } ");
            }

            Console.ReadLine();
        }
    }
}
