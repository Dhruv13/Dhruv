using System;

public class Student
{
    int id;
    string name;
    public int Roll
    {
        get
        {
            return id;
        }
        set
        {

            if (id > 0)
            {
               
                Console.WriteLine("Sucess");
                id = value;
            }

            else

            {

                Console.WriteLine("Fail");
                
            }
                  
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (name == null && name.Length<5)
                
                
           
            Console.WriteLine("sorry");
            return;
            name = value;
           
        }
    }
    public Student()
    {
        id = 0;
        //name = "";
        name = string.Empty;
       
    }
    
}
// anther Class

class product
{
    decimal rate;
    decimal qty;
    public decimal  Rate
    {
        get
        {
            return rate;
        }
        set
        {
            if (rate <= 0)
                Console.WriteLine("Negative Value Not Allow");
                return;
            rate= value;
            
        }
    }
    public decimal Qty
    {
        get
        {
            return qty;
        }
        set
        {
            if (Qty <= 0)
                Console.WriteLine("New Qntty Require");
            return;
                qty=value;
        }
    }

    public product()
    {
        rate = 5 ;
        qty = 20;


    }
    

   }



 class Test
 {
     public static void Main(String[] args)
     {
         Student s = new Student();
         //Console.Writeline();
         int a = s.Roll;
         Console.WriteLine(a);
         s.Roll = -4;   //doent give error message
         Console.WriteLine(s.Roll);
         string b = s.Name;
         Console.WriteLine(s.Name);
         s.Name = "virat";
         Console.WriteLine(s.Name);
         s.Name = "Abhi";
         Console.WriteLine(s.Name);
         s.Name = "dhruvesh";
         Console.WriteLine(s.Name);
         //================================
         product p = new product();
        decimal z=p.Rate ;
         Console.WriteLine(z);
         p.Rate = 60;    //not changed??
         Console.WriteLine(p.Rate);
         p.Qty = -25;
         Console.WriteLine(p.Qty);
         
        
        
     }
 }