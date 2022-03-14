using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //TODO GoToBase on Part1 -> go to Interface1
    public partial class Part1 : Interface1
    {
        public void Inter()
        {
            Console.WriteLine("Partial");
        }
        public void Test()
        {
            var a = new Part1();
            MethodForTest(a);
        }

        public void MethodForTest(Interface1 test)
        {
            test.Inter();
        }
    }
    //TODO GoToDeclaration on "request2" -> go to another part of this class Program.cs
    //TODO GoToBase on request2 -> IDisposible without target (now work now)
    internal partial class request2
    {
        public void App()
        {
            Console.WriteLine("");
        }
    }
}
