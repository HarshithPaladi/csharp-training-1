namespace csharp2
{

    internal class Program
    {

        public Program()
        {

        }
       public static string okAppears(string s)
        {
            while(s.Contains("ok"))
            {
                s = s.Remove(s.IndexOf("ok"), 2);
            }
            return s;
            
        }
       

        public static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();

            string t = okAppears(s);
            Console.WriteLine("created string: " + t);
        }


    }


}

//attributes and constructors
        /*
        string Name;
        int id;
        string dept;
        float grade;

        public Program(string name , int id , string department , float grade)
        {
            Console.WriteLine("inside the constructor");
            this.Name = name;
            this.id = id;
            this.dept = department;
            this.grade = grade;

        }

        public void displayStudent()
        {
            Console.WriteLine($"Details of student \nName: {Name}\nID: {id}\nDEPARTMENT: {dept}\nGRADE: {grade}");
            Console.WriteLine();
        }


        ~Program()
        {
            Console.WriteLine("destructor has been called");
        }
        /*


        //function
        public static void PrintArray(int[] a)
        {
            Console.WriteLine("Values in array: ");

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }

        //Structs

        public struct Traingle
        {

          public int side1, side2, side3,perimeter;

          public int calculatePerimeter( ) 
            {
                  return this.side1+ this.side2+ this.side3;
            }
        }


        //enumerations

        public enum days
        {
            monday,tuesday,wed,thu,fri,sat,sun
        }

        */

        //user defined exception
        /*
        public class Myexception:Exception
        {
            public Myexception(string message):base(message)
            { 
                //Console.WriteLine(message);
            }
        }

        public static void checkAge(int age) { 

            if(age<18)
            {
                throw new Myexception("Sorry your age is below 18");
            }
        }
        */

        //static void Main(string[] args)
        //  {




        //EXCEPTION HANDLING
        /*
        int age = Convert.ToInt32(Console.ReadLine());
        try
        {
            checkAge(age);
        }
        catch (Myexception e)
        {
            Console.WriteLine(e.Message);
        }

        int a = 10;
        int b = 0;
        int c;


        try
        {
            Console.WriteLine("this is try block");
            c = a / b;
        }
        catch(DivideByZeroException de)
        { 
            Console.WriteLine(de.Message);
             Console.WriteLine("please dont try to divide by zero");
        }

        catch(Exception e)
        {
            Console.WriteLine(e.Message);

            Console.WriteLine("catch block");
        }
        finally
        {
            Console.WriteLine("this is finally block");
        }
        Console.WriteLine();

        /*

        int[] arr = { 1, 2, 3, 4,5 };
        try
        {
            Console.WriteLine(arr[8]);
        }
        catch(IndexOutOfRangeException ie)
        {
            Console.WriteLine(ie.Message);
            Console.WriteLine("You are trying to access out of range index");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            Console.WriteLine("catch block");
        }
        finally
        {
            Console.WriteLine("this is finally block");
        }
        Console.WriteLine();









        // CREATING THE OBJECTS OF THE PROGRAM CLASS
        /*
        Program p1 = new Program("sravs", 1, "cs", 9.8f);
        Program myProgram1 = new Program("Latha", 10, "ece", 9.8f);

        p1.displayStudent();
        myProgram1.displayStudent();

        /*

        //ENUMS

        int a = (int) days.monday;
        Console.WriteLine(a);

        foreach(string s in Enum.GetNames(typeof(days)))

        {  Console.WriteLine(s); }

        Console.WriteLine(Enum.GetName(typeof(days), 2));

        Console.WriteLine();



        /*
       //Structs
       Traingle T = new Traingle();
       T.side1 = 1;
       T.side2 = 2;
       T.side3 = 3;
        Console.WriteLine("perimeter "+T.calculatePerimeter());


        // ARRAYS MULTI ARRAYS JAGGED ARRAYS

        int[,] a2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        int[,] a2D = new int[3, 4];

        a2D[0, 0] = 1;

        for(int i=0;i<2;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(a2[i,j]+" ");
            }
            Console.WriteLine();
        }
        */

        /*


        int[ , , ] a3D =
        {
            {
                { 1, 2, 3 } ,
                {10,20,30 }
            },
            {
                { 4,5,6 },
                { 5,6,7 }
            }
        };

        Console.WriteLine("i "+a3D.GetLength( 0 ) );

        Console.WriteLine("j "+a3D.GetLength(1));

        Console.WriteLine("k "+a3D.GetLength(2));

        for(int i=0;i<2;i++)
        {
            for(int j = 0;j<2;j++)
            {
                for(int k=0;k<3;k++)
                {
                    Console.Write(a3D[i, j, k]+" ");
                }
                Console.Write("  ");
            }
            Console.WriteLine();
        }


        /*



        int[] a = { 1, 2, 3 };
        int[] b = { 10, 20, 30};
        PrintArray(a);
        PrintArray(b);
        // Console.WriteLine("Hello, World!");
        */


        /*
        int[][] jagA = new int[2][];

        jagA[0] = new int[] {1,2,3};

        jagA[1] = new int[] {5,6};

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < jagA[i].Length; j++)
            {
                Console.Write(jagA[i][j] + " ");
            }
            Console.WriteLine();
        }


        */

        // ARRAYS MULTI ARRAYS JAGGED ARRAYS

        // myClass c = new myClass();


        //  }
  



