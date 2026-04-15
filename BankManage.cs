using System;
using System.Collections.Generic;

namespace BankManagementPractice
{
    // 1. Core Enums for Bank Roles
    public enum EmployeeRole
    {
        Teller,
        LoanOfficer,
        BranchManager,
        ComplianceAnalyst
    }

    // 2. Base Employee Class
    public class Employee
    {
        public int EmployeeId { get; private set; }
        public string FullName { get; set; }
        public EmployeeRole Role { get; set; }
        public decimal BaseSalary { get; protected set; }
        public DateTime DateJoined { get; set; }

        public Employee(int id, string name, EmployeeRole role, decimal baseSalary)
        {
            EmployeeId = id;
            FullName = name;
            Role = role;
            BaseSalary = baseSalary;
            DateJoined = DateTime.Now.AddMonths(-1); 
        }

        public virtual decimal CalculateMonthlyPayout()
        {
            return BaseSalary;
        }

        public virtual void DisplayProfile()
        {
            Console.WriteLine($"[ID: {EmployeeId}] {FullName}");
            Console.WriteLine($"Role: {Role} | Base Salary: ₹{BaseSalary:N2}");
            Console.WriteLine($"Total Monthly Payout: ₹{CalculateMonthlyPayout():N2}");
            Console.WriteLine(new string('-', 40));
        }
    }

    // 3. Derived Class demonstrating Inheritance & Polymorphism
    public class ManagerEmployee : Employee
    {
        public decimal BranchPerformanceBonus { get; set; }

        public ManagerEmployee(int id, string name, decimal baseSalary, decimal bonus) 
            : base(id, name, EmployeeRole.BranchManager, baseSalary)
        {
            BranchPerformanceBonus = bonus;
        }

        public override decimal CalculateMonthlyPayout()
        {
            return BaseSalary + BranchPerformanceBonus;
        }
    }

    // 4. Main Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Axis Digital Bank: Employee Management ===");
            Console.WriteLine();

            // Creating a list of staff members
            List<Employee> bankStaff = new List<Employee>
            {
                new Employee(101, "Amit Sharma", EmployeeRole.Teller, 45000.00m),
                new Employee(102, "Priya Nair", EmployeeRole.LoanOfficer, 65000.00m),
                new ManagerEmployee(103, "Rajesh Kumar", 120000.00m, 25000.00m),
                new Employee(104, "Sneha Reddy", EmployeeRole.ComplianceAnalyst, 75000.00m)
            };

            // Displaying all profiles
            foreach (var employee in bankStaff)
            {
                employee.DisplayProfile();
            }

            Console.WriteLine("Process complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}