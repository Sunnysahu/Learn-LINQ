using System;
using System.Collections;
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

            //bool marksGreaterThan50 = students.All(student => student.Marks > 100);
            //Console.WriteLine($"Do all students have marks greater than 50? {marksGreaterThan50}");
            // -------------------------------------------------------------------------------------------

            // First() --> Get the first element that satisfies a condition. If no such element exists, it throws an exception.

            // var student = students.First(s => s.Marks >= 80); // Returns Single Value

            // Console.WriteLine(student.Name); // Throws Exception if no student found with marks greater than or equal to 80

            // FirstOrDefault() --> Get the first element that satisfies a condition. If no such element exists, it returns the default value (null for reference types).

            //var studentFirst = students.FirstOrDefault(s => s.Marks >= 100);

            //Console.WriteLine(studentFirst?.Name ?? "No student found with marks greater than or equal to 100"); 

            // Returns null if no student found with marks greater than or equal to 100, and we use null-coalescing operator to handle the null case and provide a default message.
            // -------------------------------------------------------------------------------------------

            // Question -> Students then Filter marks > 70 then Take only Name then Convert to List

            //var studentMarksGreaterThan70 = students.Where(student => student.Marks > 70).
            //    Select(student => student.Name).ToList();

            //foreach(var student in studentMarksGreaterThan70)
            //{
            //    Console.WriteLine($"Name : {student}");
            //}

            // -------------------------------------------------------------------------------------------

            // Where with multiple conditions -- Where with AND / OR -- Where with string functions -- Where with complex filtering -- Query vs Method syntax

            // Example : Get students with marks greater than 70 AND age less than 25

            //var result = students.Where(student => student.Marks > 70 && student.Age < 22);

            // Example : Get students with marks greater than 70 OR age less than 25

            //var result2 = students.Where(student => student.Marks > 70 || student.Age < 22);

            // Example — String Filtering --> Get students whose name starts with 'S'

            //var result3 = students.Where(student => student.Name.StartsWith("s"));

            // Example -- Using Contains --> Name contains "a"

            //var result4 = students.Where(s => s.Name.Contains("a"));

            // Example -- Using EndsWith --> Name ends with "a"
            //var result5 = students.Where(s => s.Name.EndsWith("a"));

            // Example -- Using complex filtering --> Get students with marks greater than 70 AND age less than 25 OR name starts with 'S'

            //var result6 = students.Where(student => (student.Marks > 70 && student.Age < 25) || student.Name.StartsWith("S"));

            // -------------------------------------------------------------------------------------------

            // Select() in deep --> Selecting single column -- Selecting multiple columns -- Creating new objects -- Anonymous types -- Transforming data

            // Example — Select Multiple Fields 

            //var multipleFieldNameandAge = students.Select(s => new
            //{
            //    s.Name,
            //    s.Age
            //});

            // Example - Transform Data --> Add 10 bonus marks

            //var bonusMarks = students.Select(s => new 
            //{
            //    Name = s.Name,
            //    updatedMarks = s.Marks + 10
            //});

            // Example — Create New Object

            //var studentResults = students.Select(s => new StudentResult
            //{
            //    Name = s.Name,
            //    Marks = s.Marks
            //});


            // Example --> Combine Where() + Select() --> Students with Marks > 70 Return only their names

            //var studentResult = students.Where(s => s.Marks > 70).Select(s => s.Name);

            // Example — Anonymous Types --> When you want to create a new type on the fly without defining a class for it. It is useful when you need to return a subset of properties or when you want to create a temporary object for a specific purpose.

            //var anonymousType = students.Select(s => new
            //{
            //    StudentName = s.Name,
            //    StudentMarks = s.Marks
            //});


            // -------------------------------------------------------------------------------------------

            // OrderBy() and OrderByDescending() --> Sorting in LINQ -- Multiple sorting -- ThenBy() -- ThenByDescending()

            // OrderBy() --> Sort Ascending

            //var sort = students.OrderBy(x => x.Marks);

            // OrderByDescending() --> Sort Descending

            //var sortDescending = students.OrderByDescending(x => x.Marks);

            // Sorting Strings --> Sort by Name Ascending

            //var sortByName = students.OrderBy(s => s.Name);

            // ThenBy() --> Multiple Sorting --> Sort by Marks Ascending and then by Age Ascending
            // Primary sort → Marks and If same marks → Age

            //var sortByMarksThenAge = students.OrderBy(s => s.Marks).ThenBy(s => s.Age);

            // Descending + Second Sort --> Sort by Marks Descending and then by Age Ascending

            //var sortByMarksDescendingThenAge = students.OrderByDescending(s => s.Marks).ThenBy(s => s.Age);

            // Sorting After Filtering --> Get students with marks greater than 70 and sort by Age Descending

            //var filteredAndSorted = students.Where(s => s.Marks > 70).OrderByDescending(s => s.Age);

            // Sorting After Select --> Get names and Marks of students and sort by Marks

            //var nameAndMarksSortedByName = students.Select(s => new { s.Name, s.Marks }).OrderBy(s => s.Marks);

            // ThenByDescending() --> Sort by Marks Ascending and then by Age Descending

            //var sortByMarksThenAgeDescending = students.OrderBy(s => s.Marks).ThenByDescending(s => s.Age);

            // -------------------------------------------------------------------------------------------


            // Element Operators in LINQ --> First() -- FirstOrDefault() -- Last() -- LastOrDefault() -- Single() -- SingleOrDefault()

            // First() --> Returns the first element that matches the condition. If no element exists → exception occurs.

            // Example: Get the first student with marks greater than 80

            //var studentGreaterThan80 = students.First(s => s.Marks > 80);
            //Console.WriteLine(studentGreaterThan80.Name);

            // FirstOrDefault() --> Returns the first element that matches the condition. If no element exists → returns default value (null for reference types).

            //var studentGreaterThan100 = students.FirstOrDefault(s => s.Marks > 100);

            //if (studentGreaterThan100 != null)
            //{
            //    Console.WriteLine(studentGreaterThan100.Name);
            //}

            // Single() --> Used when exactly one record must exist. If no element exists → exception occurs. If more than one element exists → exception occurs.

            //var singleStudent = students.Single(s => s.Marks == 90);

            //Console.WriteLine(singleStudent.Name);

            // SingleOrDefault() --> Used when at most one record must exist. If no element exists → returns default value (null for reference types). If more than one element exists → exception occurs.

            //var studentSingleOrDefault = students.SingleOrDefault(s => s.Marks == 90);
            //if (studentSingleOrDefault != null)
            //{
            //    Console.WriteLine(studentSingleOrDefault.Name);
            //}

            // Last() --> Returns the last element that matches the condition. If no element exists → exception occurs.

            //var lastStudent = students.Last(s => s.Marks > 70);

            //Console.WriteLine(lastStudent.Name);

            // LastOrDefault() --> Returns the last element that matches the condition. If no element exists → returns default value (null for reference types).

            //var lastStudentGreaterThan100 = students.LastOrDefault(s => s.Marks > 100);

            //if (lastStudentGreaterThan100 != null) Console.WriteLine(lastStudentGreaterThan100.Name);

            // -------------------------------------------------------------------------------------------

            // Contains --> Check if a collection contains a specific element. It is used to determine if a particular value exists in a collection.


            var names = students.Select(s => s.Name);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            bool containsName = students.Select(s => s.Name.ToLower()).Contains("sunny");
            Console.Write(containsName); // True
            // -------------------------------------------------------------------------------------------

            // Partitioning Operators --> Take() -- Skip() -- TakeWhile() -- SkipWhile()

            // Take() – Take First N Elements

            var firstThreeStudents = students.Take(3);

            // Skip() – Skip First N Elements (Used when you want to ignore the first N elements)

            var skipTwoStudents = students.Skip(2);

            // Take() + Skip() (Pagination) – Take 3 elements after skipping first 2 elements
            // Page size = 2 -- Page number = 2

            var pagination = students.Skip(2).Take(3);

            // TakeWhile() – Take Until Condition Fails (When condition becomes false → stop)

            var result = students.TakeWhile(s => s.Marks < 85);

            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------
            // -------------------------------------------------------------------------------------------
        }


        // -------------------------------------------------------------------------------------------
        // -------------------------------------------------------------------------------------------
        class StudentResult
        {
            public string Name { get; set; }
            public int Marks { get; set; }
        }
    }
}