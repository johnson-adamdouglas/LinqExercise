using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //DONE: Print the Sum of numbers
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //DONE: Print the Average of numbers
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //DONE: Order numbers in ascending order and print to the console
            var ascendingNumbers = numbers.OrderBy(x => x);
            foreach (var number in ascendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Order numbers in decsending order and print to the console
            var descendingNumbers = numbers.OrderByDescending(x => x);
            foreach (var number in descendingNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Print to the console only the numbers greater than 6
            var overSix = numbers.Where(x => x > 6);
            foreach (var number in overSix)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            var anyOrder = numbers.OrderBy(x => x).Where(x => x > 0 && x % 2 == 0);
            foreach (int number in anyOrder)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            //DONE: Change the value at index 4 to your age, then print the numbers in decsending order
            numbers[4] = 38;
            var descendingWithAge = numbers.OrderByDescending(x => x);
            foreach (var number in descendingWithAge)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //DONE: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            var cAndSAscending = employees.OrderBy(x => x.FirstName).Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S"));
            //
            foreach (var employee in cAndSAscending)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine();

            //DONE: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var oldEmployees = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var employee in oldEmployees)
            {
                Console.WriteLine($"{employee.FullName} is {employee.Age} years old.");
            }
            Console.WriteLine();

            //DONE: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var experienced = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            var empSum = experienced.Sum(x => x.YearsOfExperience);
            var empAvg = experienced.Average(x => x.YearsOfExperience);

            Console.WriteLine($"Sum is {empSum}, and average is {empAvg}");
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee() { YearsOfExperience = 1, Age = 20, FirstName = "Johnny", LastName = "Appleseed" }).ToList();
            foreach(var employee in employees)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine(employees.Count);

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
