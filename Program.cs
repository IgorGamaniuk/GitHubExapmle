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

            Console.ReadLine();
        }
    }
}
