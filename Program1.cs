using System;

class mas1
{
    public double[] m;

    public mas1(int n)
    {
        m = new double[n];
        for(int i = 0; i < n; i++)
        {
            m[i] = (double)int.Parse(Console.ReadLine());
        }
    }

    public void print()
    {
        foreach(double i in m)
        {
            Console.Write($"{i}    ");
        }
    }

}

namespace kkk1
{
    class Program
    {
        static void Main(string[] args)
        {
            mas1 m = new mas1(int.Parse(Console.ReadLine()));
            m.print();
        }
    }
}
