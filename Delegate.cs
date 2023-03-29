using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharpTraining
{
    public class DelegateClass
    {

        public int id = 1;

        //Built in delegates

        //Using built in action 

        public Action<string> builtInAction = (msg) => Console.WriteLine(msg);


        //using built in func 

        public Func<int, int, int> FuncAdd = (a, b) =>
        {
            Console.WriteLine(a + b);
            return a + b;

        };

        //Recursive func

        Func<int, int> fact;




        /*fact = (num)=>
            {
                if(num == 0 ||  num==1)
                    return 1;
                 else
                    return num* fact(num-1);
    };*/


    // changes made in func modifies the value outside of this scope
    public Func<DelegateClass, DelegateClass> FuncObj = (d) =>
        {
            d.id = 10;  //id is changed to 10;
            return d;
        };


        //built in predicate
        //checks the critirea and returns boolean 
        //only takes one argument
        public Predicate<int> predicateGreater1 = (a) =>
        {
            return a > 20;
        };

        

        public Predicate<List<int>> checkifGreaterThanFive = (list) => list.All((a) => a > 5);

        

        //user defined delegate
        public  delegate void toPrintString(string s);



        public void Hellowolrd(string s)
        {
            Console.WriteLine(s);
        }

    }
}
