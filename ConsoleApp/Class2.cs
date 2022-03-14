using SharedProject1;

namespace ConsoleApp1
{
    //TODO GoToDeclaration on "request2" -> popup with select target Program.cs or Part2.cs
    internal abstract partial class Class2 : request2
    {
        
    }

    internal partial class Class2 
    {

    }
    internal partial class Class3 : request2
    {

    }

    internal partial class Class3
    {

    }
    //TODO GoToDeclaration on "Class1" -> go to class Class1.cs in ConsoleApp1 without target
    class MyClass : Class1
    {
        
    }
    //TODO GoToBase on MyClasse -> open popup with class and interface IDisposible without target (not work now)
    class MyClasse : Class1
    {

    }
    //TODO GoToDeclaration on "ClassTest" -> go to class ClassTest.cs in SharedProject1
    class MyClass2 : ClassTest
    {
        public MyClass2(int n) : base(n)
        {
        }
    }

    class MyClass3 : SharedProject1.Class1
    {

    }
    //TODO GoToBase on MyClass4 -> go to Class1
    class MyClass4 : SharedProject1.Class1
    {

    }

}
