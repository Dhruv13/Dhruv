using System;
// structure in C#
struct Student
{
    public int Roll;
    public string Name;
    public Student(int roll,string name)
    {
        Roll = roll;
        Name = name;
    }
}
class Test
{
 static void Main()
    {
        Student a = new Student(1,"Dhruv");
        Console.WriteLine(a.Name+"\n"+a.Roll);
        Student b = default(Student);
        b.Roll = 5;
        b.Name = "dhruc";
        Console.WriteLine(b.Name + "\n" + b.Roll);

    }
    
}