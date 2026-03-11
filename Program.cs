using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Learn_LINQ
{
    internal class Program
    {
        private class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Marks { get; set; }
        }

        private static void Main(string[] args)
        {
            Console.Title = "Student Management Console"; // Working till Execution Happening
            //bool bol = Console.CapsLock;
            //Console.WriteLine($"Is Caps Lock On? {bol}");

            //Console.WindowHeight = 500;
            //Console.WindowWidth = 500;

            //Console.BufferHeight = 200;
            //Console.BufferWidth = 120;

            // Console.Beep(1000, 1800); // Just for Fun :P
            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Name="Sunny", Age=25, Marks=80 },
                new Student{ Id = 2, Name="Sanna", Age=20, Marks=65 },
                new Student{ Id = 3, Name="Aditi", Age=23, Marks=90 },
                new Student{ Id = 4, Name="Neha", Age=22, Marks=70 },
                new Student{ Id = 5, Name="Priya", Age=19, Marks=85 }
            };

            // LINQ Query Syntax - In query syntax, we use a SQL-like syntax to write LINQ queries. It is more readable and easier to understand for those familiar with SQL.

            // LINQ Method Syntax - In method syntax, we use extension methods to write LINQ queries. It is more concise and allows for more complex queries.

            // LINQ Query + Method Syntax - We can also combine both query syntax and method syntax in a single LINQ query. This allows us to take advantage of the readability of query syntax while also using the power of method syntax for more complex operations.

            // Query Syntax : Get students age > 21

            //var studentAbove21 = from student in students where student.Age > 21 select student;

            //foreach(var student in studentAbove21)
            //{
            //Console.WriteLine($"Students above 21 years of age: {student.Id} {student.Name} {student.Age} {student.Marks}");

            // from s in students -> data source
            // where condition -> filter
            // select s        -> output
            //}

            // -------------------------------------------------------------------------------------------

            // Method Syntax : Get students age > 21

            //var studentAbove21Method = students.Where(student => student.Age > 21);
            //foreach (var student in studentAbove21Method)
            //{
            //    Console.WriteLine($"Students above 21 years of age: {student.Id} {student.Name} {student.Age} {student.Marks}");

            //    // Where() -> filter method and student => student.Age > 21->lambda expression
            //}

            //Console.ForegroundColor = ConsoleColor.Green;

            // -------------------------------------------------------------------------------------------

            // Collection → Filter → Transform → Flatten → Aggregate → Materialize || students → Where() → Select() → ToList()

            // WHERE --> Filter the collection based on a condition 
            // Example: Get students with marks greater than 80

            //var studentsWithMarksGreaterThan80 = students.Where(student => student.Marks > 80).ToList();

            //foreach (var student in studentsWithMarksGreaterThan80)
            //{
            //    Console.WriteLine($"Students with marks greater than 80: {student.Id} {student.Name} {student.Age} {student.Marks}");
            //}

            // -------------------------------------------------------------------------------------------

            // SELECT --> Use Select when you want to pick specific fields or create a new shape.

            // Example: Get the names of all students Only (Normall it returns whole data of each student after filtering but here we want only names)

            //var studentNames = students.Select(student => student.Name);
            //foreach (var name in studentNames)
            //{
            //    Console.WriteLine($"Student Name: {name}");
            //}

            // -------------------------------------------------------------------------------------------

            // SelectMany() --> Use SelectMany when you have a collection of collections and you want to flatten it into a single collection.

            // Example: Instead of returning full student objects, return only Name.

            //var names = students.Select(s => s.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Student Name : {name}");
            //}

            //Example 2 : Dont Run this, added Courses property in Student class and added some courses for each student, now we want to get all courses of all students in a single list.

            //class StudentCourse
            //{
            //    public string Name { get; set; }
            //    public List<string> Courses { get; set; }
            //}

            //List<Student> students = new List<Student>
            //{
            //    new Student { Name="Sunny", Courses = new List<string>{"Math","Physics"} },
            //    new Student { Name="Rahul", Courses = new List<string>{"Biology","Chemistry"} }
            //};
            // -------------------------------------------------------------------------------------------

            // ToList() --> when you want to execute the query and get the results as a List. It is used to materialize the query results into a concrete collection.

            //var studentAge = students.Where(student => student.Age > 21).ToList();
            //foreach (var student in studentAge)
            //{
            //    Console.WriteLine($"Students above 21 years of age: {student.Id} {student.Name} {student.Age} {student.Marks}");
            //}

            // -------------------------------------------------------------------------------------------

            // Any() → Check if data exists

            //bool anyStudentAbove21 = students.Any(student => student.Age > 30);

            //Console.WriteLine($"Is there any student above 21 years of age? {anyStudentAbove21}");
            // -------------------------------------------------------------------------------------------

            // All() → Check if all data satisfies a condition

            bool marksGreaterThan50 = students.All(student => student.Marks > 100);
            Console.WriteLine($"Do all students have marks greater than 50? {marksGreaterThan50}");
            // -------------------------------------------------------------------------------------------


            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------
        }
    }
}