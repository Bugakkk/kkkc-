using System;
namespace kkk_3_2{
    abstract class dim{
        protected static Random rnd = new();

        protected static double average;

        public abstract void Set();

        public abstract void Fill();

        public abstract void Show();

        public abstract double Average();
    }
}