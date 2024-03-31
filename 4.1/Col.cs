using System;



namespace kkk_4_1
{
    class Coll<T> : ICol<T>
    {
        private T[] arr;
        private int last_el = -1;

        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public Coll(int length = 7)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(length);
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
                this.Resize(arr.Length * 2 + 1);

                arr[last_el + 1] = el;
                last_el++;
            }
        }

        private void Resize(int length)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(length);

            T[] new_arr = new T[length];

            for(int i = 0; i < arr.Length; i++)
            {
                new_arr[i] = arr[i];
            }

            arr = new_arr;
        }

        public void Remove(T el)
        {
            int index = Array.IndexOf(arr, el);

            for(int i = index; i < last_el; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[last_el] = default;
            last_el--;
        }

        public int Count(Func<T, bool> condition)
        {
            ArgumentNullException.ThrowIfNull(condition);
            int count = 0;

            for(int i = 0; i < last_el + 1; i++)
            {
                if(condition(arr[i]))
                {
                    count++;
                }
            }

            return count;
        }

        public void Print(Func<T, bool> condition)
        {
            ArgumentNullException.ThrowIfNull(condition);
            if(last_el >= 0)
            {
                Console.Write("[");

                for(int i = 0; i < last_el + 1; i++)
                {
                    if(condition(arr[i]))
                    {
                        Console.Write($"{arr[i]}" + (i != last_el ? ", " : ""));
                    }
                }

                Console.Write("]\n");
            }

            else{
                Console.WriteLine("[]");
            }
        }

        public void Reverse()
        {
            T[] new_arr = new T[last_el + 1];
            int j = 0;

            for(int i = last_el; i >= 0; i--)
            {
                new_arr[j] = arr[i];
                j++;
            }

            arr = new_arr;
        }

        public bool CheckOne(Func<T, bool> condition, int index)
        {
            ArgumentNullException.ThrowIfNull(condition);
            if(index > last_el) throw new Exception("List index out of range.");
            return condition(arr[index]);
        }

        public bool[] CheckAll(Func<T, bool> condition)
        {
            ArgumentNullException.ThrowIfNull(condition);
            bool[] ret_arr = new bool[last_el + 1];
            
            for(int i = 0; i < last_el + 1; i++)
            {
                ret_arr[i] = condition(arr[i]);
            }

            return ret_arr;
        }

        public T GetElement(Func<T, bool> condition)
        {
            ArgumentNullException.ThrowIfNull(condition);
            foreach(T i in arr)
            {
                if(condition(i)) return i;
            }
            return default;
        }

        public T[] GetElements(Func<T, bool> condition)
        {
            ArgumentNullException.ThrowIfNull(condition);
            Coll<T> ret_arr = new Coll<T>(0);

            foreach(T i in arr)
            {
                if(condition(i)) ret_arr.Append(i);
            }
        
            return ret_arr.arr;
        }

        public T[] Slice(int start, int end)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(start);
            ArgumentOutOfRangeException.ThrowIfNegative(end);
            if(end < start) throw new Exception("End cannot element be before start element.");
            if(end > last_el) throw new Exception("List index out of range.");

            T[] ret_arr = new T[end - start];
            int j = 0;

            for(int i = start; i < end; i++)
            {
                ret_arr[j] = arr[i];
                j++;
            }

            return ret_arr;
        }

        public void Sort()
        {
            Comparer<T> comparer = Comparer<T>.Default;

            for(int i = 1; i < last_el; i++)
            {
                int j = i;

                T k = arr[i];

                while (j > 0 && comparer.Compare(arr[j - 1], k) > 0)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = k;
            }
        }

        public T Min()
        {
            Comparer<T> comparer = Comparer<T>.Default;

            T min = arr[0];

            for (int i = 1; i < last_el; i++)
            {
                if (comparer.Compare(arr[i], min) == -1)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public T Max()
        {
            Comparer<T> comparer = Comparer<T>.Default;

            T max = arr[0];

            for (int i = 1; i < last_el; i++)
            {
                if (comparer.Compare(arr[i], max) > 0)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}