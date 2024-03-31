using System;

namespace kkk_4_1
{
    class Program
    {
        public static void Main()
        {
            Coll<int> m = new Coll<int>(10);
            for(int i = 0; i < 10; i++)
            {
                m.Append(int.Parse(Console.ReadLine()));
            }

            m.Print(x => true);
            m.Remove(int.Parse(Console.ReadLine()));
            m.Print(x => true);
            m.Reverse();
            m.Print(x => true);
            m.Print(x => x % 2 == 0);

            Console.WriteLine("--------------------------");

            Coll<bool> m2 = new Coll<bool>();
            for(int i = 0; i < 10; i++)
            {
                m2.Append(bool.Parse(Console.ReadLine()));
            }

            Console.WriteLine(m2.Count(x => x));
            bool[] temp = m2.Slice(5, 9);

            Console.Write("[");
            for(int i = 0; i < temp.Length; i++)
            {
                Console.Write($"{temp[i]}" + (i != temp.Length - 1 ? ", " : ""));
            }
            Console.Write("]\n");

            Console.WriteLine("--------------------------");

            Coll<float> m3 = new Coll<float>();
            for(int i = 0; i < 4; i++)
            {
                m3.Append(float.Parse(Console.ReadLine()));
            }

            m3.Sort();
            m3.Print(x => true);
            Console.WriteLine(m3.Min());
            Console.WriteLine(m3.Max());

            float[] temp2 = m3.GetElements(x => x > 1.0);

            Console.Write("[");
            for(int i = 0; i < temp2.Length; i++)
            {
                Console.Write($"{temp2[i]}" + (i != temp2.Length - 1 ? ", " : ""));
            }
            Console.Write("]");
        }
    }
}