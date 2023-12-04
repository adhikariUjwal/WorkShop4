using System;
namespace ConsoleApp4
{
    internal class Home
    {
        static void Main(string[] args)
        {
            GenericsCheck<int> genericsCheck = new GenericsCheck<int>();
            GenericsCheck<string> genericsCheck1 = new GenericsCheck<string>();

            Console.WriteLine(genericsCheck.Output(5, 4));
            Console.WriteLine(genericsCheck1.Output("Monev","Adhikari"));
        }

       
    }
}
