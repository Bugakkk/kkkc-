using System;

namespace kkk_4_1
{
    interface ICol<T>
    {
        void Append(T el);

        void Remove(T el);

        int Count(Func<T, bool> condition);

        void Print(Func<T, bool> condition);

        void Reverse();

        bool CheckOne(Func<T, bool> condition, int index);

        bool[] CheckAll(Func<T, bool> condition);

        T GetElement(Func<T, bool> condition);

        T[] GetElements(Func<T, bool> condition);

        T[] Slice(int start, int end);

        void Sort();

        T Min();

        T Max();
    }
}