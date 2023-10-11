using System;
using System.Text.RegularExpressions;

namespace task11_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine($"Telebenin adi:   {student.Name}");
            Console.WriteLine($"Telebenin yasi:   {student.Age}");
            Console.WriteLine($"telebenin derecesi:   {student.Grade}");
        }

    }
    class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                Regex regex = new Regex(@"^\b[A-Z][a-z]*( [A-Z][a-z]*)*\b$");

                if (regex.IsMatch(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad yanlis daxil edilib. Yeniden daxil edin");
                    Name = Console.ReadLine();
                }


            }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value <= 70)
                {
                    _age = value;

                }
                else
                {
                    Console.WriteLine("Yanlis yas daxil edildi. 0 ve 70 araliqinda yas daxil edin.");
                    Age = int.Parse(Console.ReadLine());
                }
            }

        }

        private int _grade;
        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade = value;

                }
                else
                {
                    Console.WriteLine("Derece duzgun daxil edilmedi. 0 ile 100 araliqinda olmalidir.");
                    Grade = int.Parse(Console.ReadLine());
                }
            }

        }
        public Student()
        {
            Console.WriteLine("Ad daxil edin");
            Name = Console.ReadLine();
            Console.WriteLine("Yas daxil edin");
            Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Qiymet daxil edin");
            Grade = int.Parse(Console.ReadLine());
        }
    }
}
