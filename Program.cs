using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_LINQ
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Marks { get; set; }
        }
        static void Main(string[] args)
        {
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


        }





    }
}
