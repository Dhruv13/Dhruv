// Importing User Define Namespace As Well As System Define Namespaces
using System;
using Engneering;
using Bsc;
using Bsc.maths;
using Engneering.Civil.BuildingDrawing;
// Use of Globle Keyword 
namespace globlenameDemo
{
    public class Test1 
    {
        void getdata()
        {
            Console.WriteLine("I am Not globle"); 
        }
    }
}
public class Test1 
{
void putdata()
    {
        Console.WriteLine("I am Globle");
    }
}
    class Test2
    {
        static void Main()
        {
            global::Test1 T;
            

        }
    }