using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SujalFirstConsoleApplication
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            // Arithmetic operators
            int a = 10, b = 3;
            //comparition and logical operators
        bool r1 = (5 > 3); // true
        bool r2 = (5 == 5); // true
        bool r3 = (5 != 4); // true
           // Logical operators
         bool and = r1 && r2; // true – AND
         bool or = r1 || false; // true – OR
         bool not = !r1; // false – NOT
                  //null operators
         string name = null;
        // Null-coalescing: use default if null
         string display = name ?? "Anonymous";
            // Null-coalescing assignment
            if (name == null)
            {
                name = "Guest";
            }
            // Null-conditional: safe member access
            int? len = name?.Length; // null if name is null

            Console.WriteLine(display);
            Console.WriteLine(len);
            Console.WriteLine(name);
            Console.WriteLine(r3);
            Console.WriteLine(a + b); // 13 – Addition
            Console.WriteLine(a - b); // 7 – Subtraction
            Console.WriteLine(a * b); // 30 – Multiplication
            Console.WriteLine(a / b); // 3 – Integer division
            Console.WriteLine(a % b); // 1 – Modulus (remainder)
            Console.WriteLine(Math.Pow(a, b)); // 1000 – Power
        }
    }
}
