using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Please enter your Address?");
            string address = Console.ReadLine();
            Console.WriteLine("Please enter your Date of birth?");
            string dateofbirth = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Personal Information:    " + "First name is "  + firstname + " , Last name is " + lastname + ", Address " +
                address + ", Date of birth " + dateofbirth + ", Age " + age);

            Console.WriteLine("Welcome to Bangladesh ");
            Console.ReadKey();
        }
    }
}
