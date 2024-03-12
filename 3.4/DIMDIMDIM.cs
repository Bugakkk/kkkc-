using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace kkk_3_4
{
    interface IPrinter
    {
        void Print();
    }


    interface IDim
    {
        void Set();


        void Fill();


        void Show();
    }

    class DayOfWeek : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Понедельник, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье.");
        }
    }

    interface IThrower<T>
    {
        T Throw();
        T Set();
    }


    class IntThrower : IThrower<int>
    {
        private Random rnd = new Random();


        public int Throw() 
        {
            return rnd.Next(0, 101);
        }


        public int Set()
        {
            return int.Parse(Console.ReadLine());
        }
    }


    class BoolThrower : IThrower<bool>
    {
        private Random rnd = new Random();


        public bool Throw()
        {
            return rnd.Next(0, 2) == 1 ? true : false;
        }


        public bool Set()
        {
            return bool.Parse(Console.ReadLine());
        }
    }


    class DoubleThrower : IThrower<double>
    {
        private Random rnd = new Random();


        public double Throw()
        {
            return rnd.NextDouble();
        }


        public double Set()
        {
            return double.Parse(Console.ReadLine());
        }
    }


    class StringThrower : IThrower<string>
    {
        private Random rnd = new Random();
        private string letterlist = "qwertyiopasdfghklzxcvbnm1234567890-=+!?<>";


        public string Throw()
        {
            string s = "";
            int n = rnd.Next(5, 11);


            for(int i = 0; i < n; i++)
            {
                s += letterlist[rnd.Next(0, letterlist.Length - 1)];
            }


            return s;
        }


        public string Set()
        {
            return Console.ReadLine();
        }
    }
}