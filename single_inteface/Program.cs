using System;

namespace single_inteface
{
    interface test1
    {
        public void Show();
    }

    class demo : test1
    {
        public void Show()
        {
            Console.WriteLine("this method id Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.Show();
            Console.ReadLine();
        }
    }
}
