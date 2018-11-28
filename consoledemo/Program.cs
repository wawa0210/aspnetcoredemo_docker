using System;
using System.Threading;

namespace consoledemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                Console.WriteLine("Hello World, the current time is :"+DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss ffff"));
                Thread.Sleep(500);
            }
        }
    }
}
