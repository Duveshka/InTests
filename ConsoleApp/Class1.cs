using System;
using SharedProject1;

namespace ConsoleApp1
{
    //TODO GoToDeclaration on "IDisposible" -> go to interface IDisposible.cs without target (not work now)
    //TODO GoToImplementation on Class1 -> popup with two classes without target
    //TODO GoToDeriv on Class1 -> popup with two classes without target 
    //TODO GoToImplementation on IDisposible -> popup with six classes without target (not work now) and without duplicate request2
    //TODO GoToDeriv on IDisposible -> popup with seven classes without target (not work now) and don't show class2 for class3 (not work now)
    //TODO ShowUsages on Class1 -> popup wth three variants
    public class Class1 : IDisposable 
    {
        public void Dispose()
        {
            Console.WriteLine("");
        }
    }
    public abstract class Shape
    {
        public abstract int GetArea();
    }

    public class Square : Shape
    {
        int side;

        public Square(int n) => side = n;

        public override int GetArea() => side * side;
    }

    public class Class444 : Inter1
    {

    }

}
