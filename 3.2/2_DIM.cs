using System;

namespace kkk_3_2{
    class dim2 : dim{
        private int[,] mass;

        public Random rnd = new();

        public int[,] Mass{ get{ return mass; } }

        public double Averag{ get{ return average; } }

        public override void Set(){
            Console.Write("Array width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Array height: ");
            int height = int.Parse(Console.ReadLine());
            
            mass = new int[height, width];
            for(int y = 0; y < height; y++){
                Console.WriteLine($"Enter row {y + 1} of the array:");
                for(int x = 0; x < width; x++){
                    mass[y, x] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void Fill(){
            Console.Write("Array width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Array height: ");
            int height = int.Parse(Console.ReadLine());

            mass = new int[height, width];
            for(int y = 0; y < height; y++){
                for(int x = 0; x < width; x++){
                    mass[y, x] = rnd.Next(-1000, 1000);
                }
            }
        }

        public override void Show(){
            Console.WriteLine($"Array :");

            for(int y = 0; y < mass.GetLength(0); y++){
                if(y % 2 == 0){
                    for(int x = 0; x < mass.GetLength(1); x++){
                        Console.Write($"{mass[y, x]}\t");
                    }
                    Console.Write("\n");
                }
                else{
                    for(int x = mass.GetLength(1) - 1; x >= 0; x--){
                        Console.Write($"{mass[y, x]}\t");
                    }
                    Console.Write("\n");
                }
            }

            Console.WriteLine($"Array (reversed) :");

            
            for(int y = 0; y < mass.GetLength(0); y++){
                for(int x = 0; x < mass.GetLength(1); x++){
                    Console.Write($"{mass[y, x]}\t");
                }
                Console.Write("\n");
            }
        }
        
        public dim2(bool fill){
            if(fill){
                this.Fill();
            }
            else{
                this.Set();
            }
            
            Console.Write("Reverse every second row? ");
            this.Show();
        }

        public override double Average(){
            average = 0.0;

            foreach(int i in mass) { average += (double)i; }

            average = average / (double)mass.Length;
            Console.WriteLine($"Array average: {average}");
            return average;
        }
    }
}