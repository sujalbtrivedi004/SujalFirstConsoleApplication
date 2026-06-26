using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SujalFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            double salary = 55_000.50;
            bool isActive = true;
            string name = "Alice";
            char grade = 'A';
            // Type inference
            var city = "New York";
            var score = 98;

            // Constant
            const double PI = 3.14159;

            // Nullable types
            int? nullableAge = null;
            string nullableName = null;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Active: " + isActive);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Score: " + score);
            Console.WriteLine("PI: " + PI);
            Console.WriteLine("Nullable Age: " + nullableAge);
            Console.WriteLine("Nullable Name: " + nullableName);

            Console.WriteLine("sujal trivedi");
            Console.ReadKey();
        }
    }

}
