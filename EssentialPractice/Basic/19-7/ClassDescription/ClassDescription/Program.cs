using System;


namespace ConstDemo
{
    public class student
    {
       private int Rollno;
        private string Name;
        public int SetRoll
        {
            set
            {
                if (value< 0)
                {
                    Console.WriteLine("Failed...");
                    return;
                }
                else
                {
                    Rollno = value;
                }
            }
            get { return Rollno; }
        }
        public string SetName
        {
            set
            { Name = value; }
            get { return Name ; }
        }
        public student()
        {
            Rollno = 1;
            Name = "STUDENT";
        }
        public void print()
        {
            Console.WriteLine("NAME    : " + Name);
            Console.WriteLine("ROLL NO : " + Rollno);
        }

        class MainClass
        {
            static void Main()
            {
                student s= new student();

                s.print();
                s.SetName = "AShish";
                s.SetRoll = -4;
                s.print();
            }
        }
    }
}