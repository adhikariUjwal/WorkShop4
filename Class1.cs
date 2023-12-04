using System;

namespace ConsoleApp4
{
    internal abstract class Demo1
    {
        public void Check()
        {
            Console.WriteLine("Just Checking");
        }

        public abstract void Checking();
        
    }

    internal class Demo2 : Demo1
    {
        public override void Checking()
        {
            throw new NotImplementedException();
        }
    }
}
