using System;
public class Student
{
    private int roll;
    string name;
    private string address;
    Double MobileNo;

    public void setroll(int v)
    {
        if (v > 0 && v < 100)
            roll = v;
    }
    public void setname(String v)
    {
        if (v == null)
            return;
        if (v.Length >= 0 && v.Length <= 25)
            name = v;
        
     }
    public void setaddress(String v)
    {
        address = v;
    }
    public void setMobileNo(Double v)
    {
        if (v == 9898242424 || v == 9898989898)
            MobileNo = v;
    }
    public int Getroll()
    {
        return roll;
    }
    public String Getname()
    {
        return name;
    }
    public string Getaddress()
    {
        return address;
    }
    public Double GetMobileNo()
    {
        return MobileNo;
    }
    


}
class test
{
    public static void Main(String[] args)
    {
        Student s = new Student();
        Console.WriteLine(s.Getroll() + "\n" + s.Getname() + "\n" + s.Getaddress() + "\n" + s.GetMobileNo());
        s.setroll(10);
        s.setname("ramesh");
        s.setaddress("PATAN,GUJRAT");
        s.setMobileNo(9898242424);
        Console.WriteLine(s.Getroll()+"\n"+s.Getname()+"\n"+s.Getaddress()+"\n"+s.GetMobileNo());


    }
}