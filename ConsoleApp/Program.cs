using System;
using SharedProject1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TODO GoToDeclaration on "Class1" -> go to class Class1.cs in ConsoleApp1 without target
            //TODO GoToBase on Class1 -> IDisposible without target (not work now)
            var a = new Class1();
            var b = a;
            int k = 10;
            var c = new ClassTest(k);
            c.GetSide();
            //TODO GoToBase on Square -> Shape
            var f = new Square(k);
            //TODO GoToDeclaration on "GetArea" -> go to class Square.cs to the method GetArea in ConsoleApp1 without target
            f.GetArea();
        }
    }

    internal partial class request2 : IDisposable
    {
        internal sealed class LocalFunctionState
        {
            public void Dispose()
            {
            }
        }
        public void Dispose()
        {
            Console.WriteLine("");
        }
    }
    //TODO GoToBase on clas441 -> popup with interface and class
    public class clas441 : Class444
    {

    }
    //TODO GoToBase on partik -> popup with parts of partial class
    public class Class90 : partik
    {

    }
}
