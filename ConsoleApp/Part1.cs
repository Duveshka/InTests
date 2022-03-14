using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public partial class Part1
    {
    }
    internal class Request : IDisposable
    {
        private void Test()
        {
            NewMethod();
        }
        //TODO ShowUsages on NewMethod -> 1 result (check settings with open popup or navigate with one usage)
        private static void NewMethod()
        {
            var s = "";

            var s2 = "";
        }

        public void Dispose()
        {
            Console.WriteLine("tozhe");
        }

        public void Add()
        {
        }
    }
}
