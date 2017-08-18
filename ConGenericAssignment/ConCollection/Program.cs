using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConCollection
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }

        public Employee()
        {

        }

        public Employee(string id, string name, string deptName)
        {
            ID = id;
            Name = name;
            DeptName = deptName;
        }

        public override string ToString()
        {
            return string.Format("ID: {0}\nName: {1}\nDeptName: {2}", ID, Name, DeptName);
        }

    }
    
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            string empId, name, dept;
            int opt;

            do
            {
                Console.WriteLine("\n1.Add\n2.Update\n3.Delete\n4.View\n5.Exit\n");

                while (!int.TryParse(Console.ReadLine(), out opt))
                {
                    Console.WriteLine("Invlid Number!");
                }

                switch (opt)
                {
                    case 1:
                        Console.Write("Enter EmpID: ");
                        empId = Console.ReadLine();
                        Console.Write("Enter Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Department: ");
                        dept = Console.ReadLine();

                        Add(new Employee(empId, name, dept));
                        break;

                    case 2:
                        Console.Write("Enter EmpID to Update: ");
                        empId = Console.ReadLine();
                        Console.Write("Enter New Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter New Department: ");
                        dept = Console.ReadLine();
                        Update(new Employee(empId, name, dept));
                        break;

                    case 3:
                        Console.Write("Enter Employee ID to Delete: ");
                        empId = Console.ReadLine();
                        Delete(new Employee(empId, null, null));
                        break;

                    case 4:
                        foreach (Employee emp in employees)
                        {
                            Console.WriteLine(emp);
                        }
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid Number!");
                        break;
                }
            } while (opt != 5);

            //employees.Add(new Employee(101, "ABC", "Dev"));
            //employees.Add(new Employee(102, "PQR", "Dev"));
            //employees.Add(new Employee(103, "XYZ", "Test"));
            //employees.Add(new Employee(104, "A", "Test"));
            //employees.Add(new Employee(105, "ABC", "Test"));
            //employees.Add(new Employee(106, "ABC", "Dev"));

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //employees.Remove(employees.Find(e => e.ID.Equals("105")));

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //int idx = employees.FindIndex(e => e.ID == 103);
            //employees[idx] = new Employee(110, "Test", "Test");

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}           

            Console.ReadLine();
        }

        public static void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public static void Update(Employee emp)
        {
            int idx = employees.FindIndex(e => e.ID == emp.ID);
            employees[idx] = emp;
        }

        public static void Delete(Employee emp)
        {
            employees.RemoveAll(e => e.ID.Equals(emp.ID));
        }
    }
}
