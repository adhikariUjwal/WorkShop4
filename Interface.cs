using System;
namespace ConsoleApp4
{
    internal interface IPlay
    {
        void Playing();
        void Pause();
        void Stop()
        {
            Console.WriteLine("This is a Stop");
        }
    }
}
