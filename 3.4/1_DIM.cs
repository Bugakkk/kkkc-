using System;
 
namespace kkk_3_4
{
    class dim1<T> : IDim, IPrinter
    {
        private T[] mass = new T[0];
        private IThrower<T> thrower;
        
        public dim1(bool fill, IThrower<T> _thrower)
        {
            thrower = _thrower;

            if(fill){
                this.Fill();
            }
            else{
                this.Set();
            }
            
            this.Show();
        }
        
        public void Set()
        {
            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            mass = new T[n];
            for(int i = 0; i < n; i++)
            {
                mass[i] = thrower.Set();
            }
        }
        
        public void Fill()
        {
            int n = new Random().Next(5, 11);

            mass = new T[n];
            for(int i = 0; i < n; i++)
            {
                mass[i] = thrower.Throw();
            }
        }
        
        public void Show()
        {
            Console.Write("Array: ");
            for(int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]}" + (i != mass.Length - 1 ? ", " : ""));
            }
            Console.Write("\n");
        }
        
        public void Print()
        {
            Show();
        }
    }
}