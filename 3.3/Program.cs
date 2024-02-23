using System;

namespace kkk_3_3
{
    class Program
    {
        static void Main()
        {
            Dim m = new Dim();
            m.Array = new IDim[3];

            Console.WriteLine("1-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m.Array[0] = new dim1(Console.ReadLine() == "Fill" ? true : false);

            Console.WriteLine("-------------------------------------------------------------\n2-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m.Array[1] = new dim2(Console.ReadLine() == "Fill" ? true : false);

            Console.WriteLine("-------------------------------------------------------------\n2-stage array:");
            Console.Write("Fill randomly or set manually an array? ");
            m.Array[2] = new dimstg(Console.ReadLine() == "Fill" ? true : false);

            Console.WriteLine("-------------------------------------------------------------");
            foreach(IDim i in m.Array)
            {
                i.Show();
                i.Average();
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}