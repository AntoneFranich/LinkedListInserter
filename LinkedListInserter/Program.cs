using System;

namespace LinkedListInserter
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListManager man = new LinkedListManager();
            Console.WriteLine("--------------Start Test---------------");
            man.AutomatedTest();
            Console.WriteLine("--------------End Test---------------");
            Console.ReadLine();
        }
    }
}
