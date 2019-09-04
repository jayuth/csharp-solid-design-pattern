using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    // interface allows us to make changes without tying to a class
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Teerapong", LastName = "Uthairat" },
                new ManagerModel { FirstName = "Lisa", LastName = "Wong"},
                new ExecutiveModel { FirstName = "Stacy", LastName = "Yao"}
            };

            // create an empty list of employees to store employee objects later
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                // add a new employee object to the list
                // convert a person object to an employee object
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress} IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive } ");
            }

            Console.ReadLine();
        }
    }
}
