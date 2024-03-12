using System;

namespace kkk_3_4
{
    class Program
    {
        static void Main()
        {
            IDim[] m = new IDim[8];

            Console.WriteLine("Int 1-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[0] = new dim1<int>(Console.ReadLine() == "Fill" ? true : false, new IntThrower());

            Console.WriteLine("-------------------------------------------------------------\nDouble 1-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[1] = new dim1<double>(Console.ReadLine() == "Fill" ? true : false, new DoubleThrower());

            Console.WriteLine("-------------------------------------------------------------\nBool 1-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[2] = new dim1<bool>(Console.ReadLine() == "Fill" ? true : false, new BoolThrower());

            Console.WriteLine("-------------------------------------------------------------\nString 1-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[3] = new dim1<string>(Console.ReadLine() == "Fill" ? true : false, new StringThrower());

            Console.WriteLine("Int 2-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[4] = new dim2<int>(Console.ReadLine() == "Fill" ? true : false, new IntThrower());

            Console.WriteLine("-------------------------------------------------------------\nDouble 2-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[5] = new dim2<double>(Console.ReadLine() == "Fill" ? true : false, new DoubleThrower());

            Console.WriteLine("-------------------------------------------------------------\nBool 2-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[6] = new dim2<bool>(Console.ReadLine() == "Fill" ? true : false, new BoolThrower());

            Console.WriteLine("-------------------------------------------------------------\nString 2-dimensional array:");
            Console.Write("Fill randomly or set manually an array? ");
            m[7] = new dim2<string>(Console.ReadLine() == "Fill" ? true : false, new StringThrower());

            Console.WriteLine("-------------------------------------------------------------");
            foreach(IDim i in m)
            {
                i.Show();
                Console.WriteLine("-------------------------------------------------------------");
            }

            IPrinter[] printers = new IPrinter[9];

            printers[0] = (IPrinter)m[0];
            printers[1] = (IPrinter)m[1];
            printers[2] = (IPrinter)m[2];
            printers[3] = (IPrinter)m[3];
            printers[4] = (IPrinter)m[4];
            printers[5] = (IPrinter)m[5];
            printers[6] = (IPrinter)m[6];
            printers[7] = (IPrinter)m[7];
            printers[8] = new DayOfWeek();


            foreach(IPrinter i in printers){
                i.Print();
                Console.WriteLine("-------------------------------------------------------------");
            }
        }
    }
}
