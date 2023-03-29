using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpTraining
{
    internal class Mainclass
    {
        public static async Task Main(string[] args)
        {
            
            
            //Async programming
            //Task<int> num = AsyncClass.number();


            //AsyncClass.method1();
            //AsyncClass.method2();
            //await num;

            //Console.WriteLine("number: " + num.Result);
            //var calculation = new System.Diagnostics.Stopwatch();
            //calculation.Start();
            var m1 = AsyncClass.method4();
            var m2 = AsyncClass.method2();
            //int num = await m1;
            
            
            //Task.WaitAll(m1,m2,m3); //waits all to be completed;
            var progress = Task.WhenAny(m1,m2);  //whenall - if all whenAny if anyone is completed
            await progress;

            if (progress.Status == TaskStatus.RanToCompletion)

            { 
                var m3 = AsyncClass.method3(1);
                //m3.Start();
            } 
            
            //var dum = await AsyncClass.dummy();
            //AsyncClass.stringMethod1();
            //Console.WriteLine(AsyncClass.dummy().Result);  // it executes dummy instead of waiting for stringMethod1 

            //AsyncClass.writeFile("C:\\Users\\HP\\Documents\\newfile.txt");
            //AsyncClass.independent();
            //calculation.Stop();
            //Console.WriteLine("Time: "+calculation.ElapsedMilliseconds);
            Console.ReadLine();                             //so that everything is executed before program terminated

            // Built In delegates
            /*DelegateClass d = new DelegateClass();

            DelegateClass.toPrintString method = d.Hellowolrd;

            method.Invoke("sravani");

            d.builtInAction.Invoke("Action delegate");
            d.FuncAdd.Invoke(1, 2);

            Console.WriteLine("Before id: " + d.id);
            d.FuncObj(d);
            Console.WriteLine("After id: "+d.id);

            Console.WriteLine(d.predicateGreater1(1));

            // to check a list 
            List<int> list = new() { 4, 3, 5, 6, 7 };
            Console.WriteLine(d.checkifGreaterThanFive.Invoke(list));*/


        }

    }
}
