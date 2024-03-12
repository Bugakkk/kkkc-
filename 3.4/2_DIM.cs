using System;

namespace kkk_3_4
{
    class dim2<T> : IDim, IPrinter
    {
        private T[,] mass;
        private IThrower<T> thrower;

        public dim2(bool fill, IThrower<T> _thrower)
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
            Console.Write("Enter array width:");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter array height:");
            int height = int.Parse(Console.ReadLine());

            mass = new T[height, width];
            for(int y = 0; y < height; y++)
            {
                Console.WriteLine($"Enter row {y + 1} of the array:");
                for(int x = 0; x < width; x++)
                {
                    mass[y, x] = thrower.Set();
                }
            }
        }

        public void Fill()
        {
            int width = new Random().Next(2, 5);
            int height = new Random().Next(2, 5);

            mass = new T[height, width];
            for(int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    mass[y, x] = thrower.Throw();
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Array:");
            for(int y = 0; y < mass.GetLength(0); y++)
            {
                for(int x = 0; x < mass.GetLength(1); x++)
                {
                    Console.Write($"{mass[y, x]}\t\t");
                }
                Console.Write("\n");
            }
        }
        
        public void Print()
        {
            Show();
        }
    }
}