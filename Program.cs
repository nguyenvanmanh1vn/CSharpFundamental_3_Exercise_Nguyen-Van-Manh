using System;
using System.Threading.Tasks;

namespace FindPrimeNumber
{
    class Program
    {
        private static bool checkPrime(int num){
            if (num <= 1) return false;
            for(int index = 2; index < num; index++){
                if(num % index == 0){
                    return false;
                }
            }
            return true;
        }
        private static async Task Task1(){
            await Task.Delay(200);
            for(int i = 1; i <= 25; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
            
        }

        private static async Task Task2(){
            await Task.Delay(200);
            for(int i = 26; i <= 50; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
        }
        private static async Task Task3(){
            await Task.Delay(200);
            for(int i = 51; i <= 75; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
        }
        private static async Task Task4(){
            await Task.Delay(200);
            for(int i = 76; i <= 100; i++)
            {
                if(checkPrime(i)){
                    Console.WriteLine(i);
                }
            }
        }
        static async Task Main(string[] args)
        {
            // Find prime number from 1 to 25
            Task task1 = Task1(); 
            // Find prime number from 26 to 50
            Task task2 = Task2(); 
            // Find prime number from 51 to 75
            Task task3 = Task3(); 
            // Find prime number from 76 to 100
            Task task4 = Task4(); 
            await task1;
            await task2;
            await task3;
            await task4;
            Task.WaitAll(task1, task2, task3, task4);
            
        }
    }
}
