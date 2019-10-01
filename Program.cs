using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            Random rand = new Random();
            int[] numbers = new int[10];
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] = rand.Next(5,26);
            }

            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min){
                    min = numbers[i];
                }
            }
            Console.WriteLine($"Max: {max}, Min {min}, Sum: {sum}");
            return numbers;
        }

        public static string TossCoin(){
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int toss = rand.Next(2);
            if(toss == 1){
                Console.WriteLine("Heads");
                return "Heads";
            }
            else{
                Console.WriteLine("Tails");
                return "Tails";
            }
        }

        public static double TossMultipleCoins(int num){
            int totalToss = 0;
            int headToss = 0;
            for(int i = 0; i < num; i++){
                string outcome = TossCoin();
                totalToss++;
                if(outcome == "Heads"){
                    headToss++;
                }
            }
            double ratio = totalToss/headToss;
            Console.WriteLine(ratio);
            return ratio;
        }

        public static string[] Names(){
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for(int i = 0; i < names.Length; i++){
                int idx = rand.Next(names.Length);
                string temp = names[idx];
                names[idx] = names[i];
                names[i] = temp;
                }
            List<string> overFive = new List<string>();
            foreach(var name in names){
                if(name.Length > 5){
                    overFive.Add(name);
                }
            }
            foreach(var person in overFive){
                Console.WriteLine(person);
            }
            return overFive.ToArray();
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine(RandomArray());
            // TossCoin();
            // TossMultipleCoins(50);
            // Names();
        }
    }
}
