using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Id = 1, Name = "student1" };
            Console.WriteLine(student.Id + " " + student.Name);

            Student student2 = new Student() { Id = 2, Name = "student2" };
            Console.WriteLine(student2.Id + " " + student2.Name);

            Address address1 = new Address() { Id = 1, StudentAddress = "student1 address", StudentId = 1 };

            Console.WriteLine(address1.StudentAddress);

            
            Console.ReadLine();
        }
    }
}
