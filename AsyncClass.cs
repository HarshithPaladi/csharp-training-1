using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTraining
{
    internal class AsyncClass
    {

        public async static Task<int> method1()
        {
            int number = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Executing method 1");
                    number++;
                }
            }); 

            Console.WriteLine("Metod1 started");
            //await Task.Delay(4000);
            Console.WriteLine("Method1 ended");
            return number;
        }
        public async static Task method4()
        {
            Console.WriteLine("Metod4 started");
            await Task.Delay(4000);
            Console.WriteLine("Method4 ended");

        }

        public async static Task method2() 
        {
            Console.WriteLine("Long Method2 started");
            await Task.Delay(6000);
            Console.WriteLine("Long Method2 ended");
        }

        public async static Task method3(int num)
        {
            Console.WriteLine($"Number from method1 {num}");
            Console.WriteLine("Method3 started");
            await Task.Delay(4000);
            Console.WriteLine("Method3 ended");
        }

        public static async Task<int> number()
        {
            Thread.Sleep(4000);
            return 10;  
        }

        //Dependency of one method on  another
        public static async Task<string> stringMethod1()
        {
            Console.WriteLine("string 1 started");
            Console.WriteLine(await stringMethod2());      //It waits till - stringMethod2 completes execution and returns the value
            Console.WriteLine("string 1 ended");
            return "1 completed";

        }

        public static async Task<string> stringMethod2()
        {
            Console.WriteLine("strng 2 started");
            await Task.Delay(5000);                          //waits for 5sec
            string mas = "msg from strig 2 method";
            Console.WriteLine("string 2 ended");
            return mas;

        }

        public static async Task dummy()                //Doesnt wait for above methods
        {
            Console.WriteLine("dummy method");  

        } 


        public static async Task<FileStream> openFile(string path)
        {
            FileStream file = null;
            Task.Run(() =>
                {
                   file = new FileStream(path, FileMode.OpenOrCreate);
                    
                });
            await Task.Delay(5000);
            return file;
        }

        public static async void independent()
        {
            Console.WriteLine("Entered independent method");
            Console.WriteLine("qutting independent method");
        }

        public static async void writeFile(string path)
        {
            FileStream file = await openFile(path);
            Console.WriteLine("File is opened and ready");
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("I am writing to the file twice");
            writer.Close();
            file.Close();
            Console.WriteLine("The file is closed");



        }

    }
}






