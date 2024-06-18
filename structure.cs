using System;

namespace Dlithe_CSharp
{
    
    struct EmployeeDetails
    {
        public int Id;
        public string Name;

        public void GetDetails()
        {
            Console.WriteLine("Enter Employee Details");
            Id = Convert.ToInt32(Console.ReadLine());
            Name = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Id:" + Id + ", Name:" + Name);
        }
    }

    internal class Structures
    {
        static void Main(string[] args)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails();
            employeeDetails.GetDetails();
            employeeDetails.DisplayDetails();
            Console.ReadLine();
        }
    }
}
