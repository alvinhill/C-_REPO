using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace CODEFIRST3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
             // THIS PROGRAM WILL ACTUALLY CREATES A DATABASE AND TABLES  
                Console.Write("Enter a name for a new Student: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
        public class Student
        {
            public int StudentId { get; set; }
            public string Name { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
        }

    }
}
