using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    interface IPrintable
    {
        void print();
    }
    class Book : IPrintable
    {
        public void print()
        {
            Console.WriteLine("Книга");
        }
    }
    class Magazine : IPrintable
    {
        public void print()
        {
            Console.WriteLine("Журнал");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrintable[] bm = new IPrintable[6];
            bm[0] = new Book();
            bm[1] = new Magazine();
            bm[2] = new Book();
            bm[3] = new Magazine();
            bm[4] = new Book();
            bm[5] = new Magazine();
            foreach (var printable in bm)
            {
                printable.print();
            }
        }
    }
}
