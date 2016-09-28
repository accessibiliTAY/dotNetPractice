//C# is case-sensitive, so keywords won't work unless they're lowercase, and other named
//elements within the source code must exactly match the case of the element being referenced.


using System;
//the "using" statement allows us to refer to elements that exist within the listed namespace
  //(in this case, System) without prefixing them with the namespace name.
//namespace is a way of organizing programming constructs. They're similar to folders or
  //directories in your file system.
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
