using System;

namespace kkk_4_1
{
    class Coll<T>
    {
        private T[] arr;
        private int last_el = -1;

        public Coll(int length = 7)
        {
            arr = new T[length];
        }

        public void Append(T el)
        {
            if(last_el < arr.Length - 1)
            {
                arr[last_el + 1] = el;
                last_el++;
            }

            else
            {
                Array.Resize(ref arr, arr.Length * 2 + 1);

                arr[last_el + 1] = el;
                last_el++;
            }
        }

        public void Remove()
        {
            arr[last_el] = default;
            last_el--;
        }

        public int Len()
        {
            return last_el;
        }

        public void Print()
        {
            if(last_el >= 0)
            {
                Console.Write("[");

                for(int i = 0; i < last_el + 1; i++)
                {
                    Console.Write($"{arr[i]}" + (i != last_el ? ", " : ""));
                }

                Console.Write("]");
                Console.Write("\n");
            }

            else{
                Console.WriteLine("[]");
            }
        }
    }
}
