using System;

public class Student
{
    private int _roll;
    private string _name;
    public int Myproperty
    {
        set
        {
            
                _roll = value;
        }
        get
        {
            return _roll;
        }
    }
    public string MypropertyName
    {
        set
        {
            if (_name == null)
               
            
                if(_name.Length>0 && _name.Length <100 )
                _name=value;
            return;
            
        }
        get
        {
            return _name;
        }
    }
    //public Student()
    //{
    //    _roll = 0;
    //    _name = "dhruv";

    //}
    class test
    {
        public static void Main(String[] args)
        {
            Student s = new Student();
            s._roll  = -14;
            s._name  = "";
            
            Console.WriteLine("No:" + s._roll  + "\nName :"+ s._name  );
        }
    }
}