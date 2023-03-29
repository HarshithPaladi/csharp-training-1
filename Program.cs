using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace csharpTraining
{
    public class MyClass<T>
    {
        //Declaring delegate in diffrent class
        public delegate T DelegateMethod(T a, T b);
    }
    internal class Program
    {
        delegate void Print(string s);
        delegate int delegateMethod(int a , int b);  //Declaring a delegate
        public static int add(int a ,int b)
        {
            Console.WriteLine("Delegate method triggered");
            Console.WriteLine(a+b);
            return a + b;
        }

        public static int sub(int a, int b)
        {


            Console.WriteLine(a - b);
            return a - b;
        }
        public static int mul(int a,int b) {


            Console.WriteLine(a * b);
            return a * b;
        }
        public static int div(int a, int b)
        {


            Console.WriteLine(a / b);
            return a / b;
        }


        /*public static void Main(string[] args)

        {



            //Lambda
            var result = (int x, int y) =>
            {
                int total = 0;
                total = x + y;
                Console.WriteLine(total);
                return total;
            };
            //int total = result(1, 2);
            //lambda as paramenter

            int[] a = { 1, 2, 3, 4, 5 };

            int count = a.Count(num => num > 3);
            //Console.WriteLine(count);

            //readymade delegates

            //Func<int, int, int> fn = (a, b) => a + b;
            Console.WriteLine(student.fn(1, 2));

            *//*List<student> students = new List<student>();
            students.Add(new student() { Id = 1, Name ="Sravani",Age = 21 ,Native="atp",Dept = "civil",});
            students.Add(new student() { Id = 2, Name = "Srav", Age = 27, Native = "gut", Dept = "ece", });
            students.Add(new student() { Id = 30, Name = "Savani", Age = 11, Native = "vij", Dept = "csbs", });
            students.Add(new student() { Id = 0, Name = "Srani", Age = -34, Native = "atp", Dept = "cse", });
            students.Add(new student() { Id = 1, Name = "Sravi", Age = 25, Native = "tpt", Dept = "it", });
            students.Add(new student() { Id = 2, Name = "Sra", Age = -12, Native = "atp", Dept = "ai", });

            foreach (var s in students)
            {
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Age:{s.Age} native:{s.Native} dept:{s.Dept}");
            }


            Console.WriteLine();
            //List<student> newStudent = students.FindAll(x => x.Age>20).ToList();
           // students.Sort((s1, s2) => s1.Age.CompareTo(s2.Age));
            students.ForEach(student => student.Id += 10);

            students.Sort((s1,s2) => (s1.Age));  //does nothing 

            students.Sort((s1, s2) => (s1.Age-s2.Age)); // similar to comapreTo 

            foreach (var s in students)
            {
                Console.WriteLine($"Id:{s.Id} Name:{s.Name} Age:{s.Age} native:{s.Native} dept:{s.Dept}");
            }*//*



        }*/

        //Lambda using class

        public class student
        {
            //public int id;
            //public string name;
            //public int age;
            //public string native;
            //public string dept;

            public int Id { set; get; }
            public string Name { set; get; }

            public int Age { set; get; }

            public string Native { set; get; }

            public string Dept { set; get; }

            public static Func<int, int, int> fn = (a, b) => a + b;

        }

        /*//Lamda expression without delegates

        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "C");
        dict.Add(3, "A");                                                                       
        dict.Add(0,"D");
        dict.Add(2, "B");

        foreach (var item in dict.OrderBy(x => x.Key).ToList() )
        {
            Console.WriteLine(item);
        }\

        //order with  multiple values
         foreach ( var kv in Dict.OrderBy( x => x.Value[1]*-1 ).OrderBy( x => x.Value[0] ) )
        {
            Console.WriteLine( $" [ {kv.Value[0]} , {kv.Value[1]} ]" );
        }

         */
        /* List<int> nums = new List<int>() { 1, 20, 3, 40, 5 };

         List<int> fiveMultiples = nums.FindAll(x => x % 5 == 0);

         List<string> s = new List<string>() { "cbc", "acd", "bdf" };

         List<string> ordered = s.OrderBy(x => x).ToList();
         var square = (int n) => { return n * n; };

         foreach (string num in ordered)
         {
             Console.WriteLine(num);
         }*/



        /*  // Using delegate - anonymous function
         * delegateMethod function = delegate (int a, int b) { return a + b; };
        Console.WriteLine(function(1, 2));

        Print print = delegate (string msg) { Console.WriteLine(msg); };
        print.Invoke("sravani");*/
        /*
                    //USING delegates - lambda expression
                    delegateMethod function = (num1, num2) => num1 + num2;
                    Console.WriteLine(function.Invoke(1,2));

                    Print print = (s) => Console.WriteLine(s);
                    print.Invoke("sravani");


                    var calculator = (int num1, int num2) => num1 + num2;
                    calculator+= (int num1, int num2) => num1 + num2;
                    calculator += (int num1, int num2) => num1 * num2;
                    calculator += (int num1, int num2) => num1 / num2;*/
        /*delegateMethod a = add;
        /*delegateMethod b = sub;
        delegateMethod c = mul;
        delegateMethod d = div;
        delegateMethod function = a+b+c+d;

        function.Invoke(1, 2);  // invokes all one by one but if we print this here it will have only lastly returned item
        //To access all methods using the delegate varaible
        foreach (delegateMethod method in function.GetInvocationList())
        {
            method.Invoke(20, 10);  // invokes all and if we prit this here it prints every returned item
        }*/
        // function(2,3);  //only add method 
        //function.Invoke(2,3);   //another way of calling

        //Accessing delegate from diffrent class
        // MyClass<int>.DelegateMethod function = add;
        //MyClass<float>.DelegateMethod function

        //function += new MyClass<float>.DelegateMethod(mul); //multi casting delegate
        //function(2,3);  //it perfoms add and mul


        //function.Invoke(2,3);  //performs only mul



    }
}