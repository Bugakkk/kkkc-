﻿using System;
using System.Numerics;

namespace kkk_3_2{
    class Program{
        static void Main(){
            Console.Write("Do 1-dimensional arrays? ");
            string do_arrays = Console.ReadLine();
            if(do_arrays == "Yes"){
                Console.Write("Fill randomly or set manually an array? ");
                dim1 m = new dim1(Console.ReadLine() == "Fill" ? true : false);
                
                m.Average();

                m.Cl100();
                m.Show();

                m.Set();
                m.ClRep();
                m.Show();
            }

//-------------------------------------------------------------------------------------------------------------------------------------

            Console.Write("Do 2-dimensional arrays? ");
            do_arrays = Console.ReadLine();
            if(do_arrays == "Yes"){
                Console.Write("Fill randomly or set manually an array? ");
                dim2 m2 = new dim2(Console.ReadLine() == "Fill" ? true : false);

                m2.Average();
            }

//------------------------------------------------------------------------------------------------------------------------------------- 

            Console.Write("Do 2-stage arrays? ");
            do_arrays = Console.ReadLine();
            if(do_arrays == "Yes"){
                Console.Write("Fill randomly or set manually an array? ");
                dimstg m3 =  new dimstg(Console.ReadLine() == "Fill" ? true : false);

                m3.Average();
                m3.Averages();
                m3.ClEven();
                m3.Show();
            }
        }
    }
}