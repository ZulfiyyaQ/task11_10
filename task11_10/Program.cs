using System;
using System.Text.RegularExpressions;

namespace task11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {//task2

            //Student student = new Student();
            //Console.WriteLine($"Telebenin adi:   {student.Name}");
            //Console.WriteLine($"Telebenin yasi:   {student.Age}");
            //Console.WriteLine($"telebenin derecesi:   {student.Grade}");


            //task1

            Employee employee1 = new Employee("Ulviyye", false, 100);
            Employee employee2 = new Employee("Fexriyye", true, 600);
            Employee employee3 = new Employee("Arzu", true, 400);


            Assistant assistant = new Assistant();
            assistant.GetFeedBack(employee1);
            assistant.GetFeedBack(employee2);
            assistant.GetFeedBack(employee3);

            Console.WriteLine($"Ishcinin  adi: {employee1.Name}  maasi: {employee1.Salary}");
            Console.WriteLine($"Ishcinin  adi: {employee2.Name}  maasi: {employee2.Salary}");
            Console.WriteLine($"Ishcinin  adi: {employee3.Name}  maasi: {employee3.Salary}");

        }

    }
    //class Student
    //{
    //    private string _name;

    //    public string Name
    //    {
    //        get { return _name; }
    //        set
    //        {
    //            Regex regex = new Regex(@"^[A-z]*$");

    //            if (regex.IsMatch(value))
    //            {
    //                _name = NormalizeName(value);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Ad yanlis daxil edilib. Yeniden daxil edin");
    //                Name = Console.ReadLine();
    //            }


    //        }
    //    }

    //    private int _age;
    //    public int Age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            if (value > 0 && value <= 70)
    //            {
    //                _age = value;

    //            }
    //            else
    //            {
    //                Console.WriteLine("Yanlis yas daxil edildi. 0 ve 70 araliqinda yas daxil edin.");
    //                Age = int.Parse(Console.ReadLine());
    //            }
    //        }

    //    }

    //    private int _grade;
    //    public int Grade
    //    {
    //        get { return _grade; }
    //        set
    //        {
    //            if (value >= 0 && value <= 100)
    //            {
    //                _grade = value;

    //            }
    //            else
    //            {
    //                Console.WriteLine("Derece duzgun daxil edilmedi. 0 ile 100 araliqinda olmalidir.");
    //                Grade = int.Parse(Console.ReadLine());
    //            }
    //        }

    //    }
    //    private string NormalizeName(string input)
    //    {
    //        input = input.Trim();
    //        if (!string.IsNullOrEmpty(input))
    //        {
    //            input = char.ToUpper(input[0]) + input.Substring(1).ToLower();
    //        }
    //        return input;
    //    }
    //    public Student()
    //    {
    //        Console.WriteLine("Ad daxil edin");
    //        Name = Console.ReadLine();
    //        Console.WriteLine("Yas daxil edin");
    //        Age = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Qiymet daxil edin");
    //        Grade = int.Parse(Console.ReadLine());
    //    }
    //}



    //task1

    public class Manager
    {
        protected Employee GetPromation(ref Employee employee)
        {
            employee.Salary = employee.Salary + 100;
            return employee;
        }
    }

    public class Assistant : Manager
    {
        public void GetFeedBack(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                GetPromation(ref employee);
            }
            else
            {
                Console.WriteLine($"{employee.Name}hec bir deyisiklik olmayib");
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public int Salary { get; set; }


        public Employee(string name, bool issuccessfull, int salary)
        {
            Name = name;
            IsSuccessfull = issuccessfull;
            Salary = salary;

        }
    }











































}
