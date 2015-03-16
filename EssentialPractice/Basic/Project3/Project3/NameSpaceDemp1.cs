/// <summary>
/// How to Use NameSpace , SubNamespace And Use Of Globle Keyword
/// Created By Dhruvesh Akhani
/// Created On 16-7-2014
/// </summary>
using System;// Globle namespace Engneering
namespace Engneering// globle namespace Engneering
{

}
namespace Engneering.ComputerScience// Create subnamespace for computerScience
{
    class SevanSem
    {
        void put()
        {
            Console.WriteLine("right??");
        }
    }
}

namespace Engneering.Civil// that create subnamespace for Engneering
{
    namespace BuildingDrawing// that create subnamespace for Civil
    {

    }

}
namespace Bsc// globlenamespace 
{
    namespace maths
    {

    }
}

// Simple Declaration of User Define Namespaces ..
// Importing User Define Namespace As Well As System Define Namespaces
//If  i write "using NamespaceName " here that gives error
// Use of Globle Keyword 
namespace globlenameDemo// globle namespace
{
    public class Test1 
    {
       public  void getdata()
        {
            Console.WriteLine("I am Not globle"); 
        }
    }
}
public class Test1 
{
public void putdata()
    {
        Console.WriteLine("I am Globle");
    }
}
    class Test2
    {
        public static void Main(string[] args)
        {
       
            global::Test1 t1=new Test1();
            t1.putdata();
            globlenameDemo.Test1 t; 
                //=new Test1();
            
            //t.getdata();

           


            

        }
    }