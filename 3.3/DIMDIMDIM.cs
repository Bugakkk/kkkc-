using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace kkk_3_3
{
    interface IPrinter
    {
        void Print();
    }

    interface IDim
    {
        double Averag{ get; }

        void Set();

        void Fill();

        void Show();

        double Average();
    }

    abstract class dim : IDim{
        protected static Random rnd = new();

        protected static double average;

        public double Averag{ get; }

        public abstract void Set();

        public abstract void Fill();

        public abstract void Show();

        public abstract double Average();
    }

    interface IDim1 : IDim
    {
        int[] Mass{ get; }

        void Cl100();

        void ClRep();
    }

    interface IDim2 : IDim
    {
        int[,] Mass{ get; }
    }

    interface IDimstg : IDim
    {
        int[][] Mass{ get; }

        double[] Averags{ get; }

        int Length{ get; }

        double[] Averages();

        void ClEven();
    }

    class Dim
    {
        public IDim[] Array{ get; set; }
    }
}