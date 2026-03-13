/*

            List<Student> students = new List<Student>()
            {
                new Student{ Id = 1, Name="Sunny", Age=25, Marks=80 },
                new Student{ Id = 2, Name="Sanna", Age=20, Marks=65 },
                new Student{ Id = 3, Name="Aditi", Age=23, Marks=90 },
                new Student{ Id = 4, Name="Neha", Age=22, Marks=70 },
                new Student{ Id = 5, Name="Priya", Age=19, Marks=85 }
            };
*/


/*
internal class StudentDetails
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public List<string> Courses { get; set; }
}

internal class StudentCourse
{
    public List<StudentDetails> students = new List<StudentDetails>()
        {
            new StudentDetails{ Id=1, Name="Sunny", Age=25, Marks=80, Courses=new List<string>{"Math","Physics"} },
            new StudentDetails{ Id=2, Name="Rahul", Age=20, Marks=65, Courses=new List<string>{"Biology"} },
            new StudentDetails{ Id=3, Name="Amit", Age=23, Marks=90, Courses=new List<string>{"Math","Chemistry"} },
            new StudentDetails{ Id=4, Name="Neha", Age=22, Marks=70, Courses=new List<string>{"Physics"} },
            new StudentDetails{ Id=5, Name="Priya", Age=19, Marks=85, Courses=new List<string>{"Math","Biology"} }
        };
}

*/