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
                T[] new_arr = new T[arr.Length * 2 + 1];

                for(int i = 0; i < arr.Length; i++)
                {
                    new_arr[i] = arr[i];
                }

                new_arr[last_el + 1] = el;
                last_el++;

                arr = new_arr;
            }
        }

        public void Remove()
        {
            arr[last_el] = default;
        }
    }
}