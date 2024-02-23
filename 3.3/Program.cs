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

            Printer _printer = new Printer();
            _printer.printers = new IPrinter[4];

            _printer.printers[0] = (IPrinter)m.Array[0];

            _printer.printers[1] = (IPrinter)m.Array[1];

            _printer.printers[2] = (IPrinter)m.Array[2];

            _printer.printers[3] = new DayOfWeek();

            foreach(IPrinter i in _printer.printers){
                i.Print();
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}