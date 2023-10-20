using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            string personName = A.Name;
            int personAge = A.Age;
            A.Name = "FAnn";
            A.Age = 19;
            A.Print();

            Console.ReadLine();
        }
    }
    
}