using System;
 
namespace kkk_3_2{
    class dim1 : dim{
        private int[] mass = new int[0];
        
        public Random rnd = new();
        
        public int[] Mass{ get{ return mass; } }
        
        public double Averag{ get{ return average; } }
        
        public override void Set(){
            Console.Write("Enter array length: ");

            int n = int.Parse(Console.ReadLine());
            mass = new int[n];

            Console.WriteLine("Enter array:");
            for(int i = 0; i < n; i++){
                mass[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public override void Fill(){
            Console.Write("Enter array length: ");

            int n = int.Parse(Console.ReadLine());
            mass = new int[n];

            for(int i = 0; i < n; i++){
                mass[i] = rnd.Next(-1000, 1000);
            }
        }
        
        public override void Show(){
            Console.Write("Array: ");

            for(int i = 0; i < mass.Length; i++){
                if(i < mass.Length - 1) Console.Write($"{mass[i]}, ");
                else Console.Write($"{mass[i]}");
            }

            Console.WriteLine("");
        }

        public dim1(bool fill){
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

            foreach(int i in mass) { average += (double)i; }

            average = average / (double)mass.Length;
            Console.WriteLine($"Array average: {average}");
            return average;
        }
        
        public void Cl100(){
            int[] temp = new int[mass.Length];
            for(int i = 0; i < mass.Length; i++) temp[i] = mass[i]; 
            
            int new_Length = 0;
            
            foreach(int i in temp){ if(Math.Abs(i) < 100) new_Length++; }
            
            mass = new int[new_Length];
            int new_i = 0;
            
            for(int i = 0; i < temp.Length; i++){
                if(Math.Abs(temp[i]) < 100){
                mass[new_i] = temp[i];
                new_i++;
                }
            }
        }
        
        public void ClRep(){
            int new_Length = mass.Length;
            
            for(int i = 0; i < mass.Length; i++){ 
                for(int j = 0; j < i; j++){
                    if(mass[j] == mass[i]) { 
                        new_Length--; 
                        break; 
                    }
                } 
            }
            
            int[] new_mass = new int[new_Length];
            int new_i = 0;
            int unmatch_count = 0;
            
            for(int i = 0; i < mass.Length; i++){
                for(int j = 0; j < i; j++){
                    if(mass[i] != mass[j]) unmatch_count++;
                }
                //Console.WriteLine(new_i);
                if(unmatch_count == i) {
                    new_mass[new_i] = mass[i]; 
                    new_i++;
                }
                unmatch_count = 0;
            }
            mass = new int[new_Length];
            mass = new_mass;
        }
    }
}