using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;


namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Person pers = new Person(18);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Person.IncreaseLegalAge(1);
            if (pers.IsAdult())
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }

    class Person
    {
        
        public Person(int age)
        {
            Age = age;
        }

        public int Age { get; set; }
        int LegalAge = 18;


        public bool IsAdult()
        {
            if (Age == LegalAge) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public static void IncreaseLegalAge(int n)
        {
            Age += n;
        }
    }
}