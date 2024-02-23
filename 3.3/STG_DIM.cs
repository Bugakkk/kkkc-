using System;

namespace kkk_3_3{
    class dimstg : dim, IDimstg, IDim{
        private int[][] mass;

        private double[] averages;

        public Random rnd = new();

        public int[][] Mass{ get{ return mass; } }

        public double Averag{ get{ return average; } }

        public double[] Averags{ get{ return averages; } }

        public int Length{
            get{
                int length = 0;
                foreach(int[] i in mass) { length += i.Length; }
                return length;
            }
        }

        public override void Set(){
            Console.Write("Enter row count: ");
            int height = int.Parse(Console.ReadLine());
            int length;

            mass = new int[height][];
            for(int y = 0; y < height; y++){
                Console.Write($"Enter row {y + 1} length: ");

                length = int.Parse(Console.ReadLine());
                mass[y] = new int[length];

                Console.WriteLine($"Enter row {y + 1}:");
                for(int x = 0; x < length; x++) { mass[y][x] = int.Parse(Console.ReadLine()); }
            }
        }

        public override void Fill(){
            Console.Write("Enter row count: ");
            int height = int.Parse(Console.ReadLine());
            int length;

            mass = new int[height][];
            for(int y = 0; y < height; y++){
                Console.Write($"Enter row {y + 1} length: ");

                length = int.Parse(Console.ReadLine());
                mass[y] = new int[length];

                for(int x = 0; x < length; x++) { mass[y][x] = rnd.Next(-1000, 1000); }
            }
        }

        public override void Show(){
            Console.WriteLine("Array:");

            foreach(int[] y in mass){
                foreach(int x in y) { Console.Write($"{x}\t"); }
                Console.Write("\n");
            }
        }

        public dimstg(bool fill){
            if(fill){
                this.Fill();
            }
            else{
                this.Set();
            }

            this.Show();
        }        

        public override double Average(){
            average = 0.0;

            foreach(int[] y in mass){
                foreach(int x in y) { average += (double)x; }
            }

            average = average / (double)this.Length;
            Console.Write($"Array average: {average}\n");
            return average;
        }

        public double[] Averages(){
            Console.WriteLine("Row averages:");
            averages = new double[mass.Length];
            for(int y = 0; y < mass.Length; y++){
                averages[y] = 0.0;
                for(int x = 0; x < mass[y].Length; x++){
                    averages[y] += (double)mass[y][x];
                }
                averages[y] = averages[y] / (double)mass[y].Length;
                Console.WriteLine(averages[y]);
            }
            return averages; 
        }

        public void ClEven(){
            int mul = 1;
            foreach(int[] y in mass){
                foreach(int x in y){
                    if(x % 2 == 0) mul *= x;
                }
            }

            for(int y = 0; y < mass.Length; y++){
                for(int x = 0; x < mass[y].Length; x++){
                    if(mass[y][x] % 2 == 0) mass[y][x] = mul;
                }
            }
        }
    }
}