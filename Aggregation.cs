using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    internal class Aggregation
    {
    }

    public class Student
    {
        public string name;
        public int age;
        public int id;
        public string dept;
        public Marks mark;

        public Student(string name,int age,int id,string dept,Marks mark)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.dept = dept;
            this.mark = mark;
        }
        public void displayDetails()
        {
            Console.WriteLine("name " + this.name);
            Console.WriteLine("age "+this.age);
            Console.WriteLine("id: "+ this.id);
            Console.WriteLine("dept: " + this.dept);
            Console.WriteLine("marks: " + this.mark.marks);
            Console.WriteLine("percentage: " + this.mark.percentage+"%");
        }
         
    }

    public class Marks {
        public int marks;
        public float percentage;
        public string grade;
        public int noOfSubs;

        public Marks(int marks, int noOfSubs)
        {
            this.marks = marks;
            //this.percentage = percentage;
            //this.grade = grade;
            this.noOfSubs = noOfSubs;
        }

        public void calcPercentage()
        {
            this.percentage = this.marks / this.noOfSubs;
           // Console.WriteLine("percentage " + percentage);

        }

        public static void Main(String[] args)
        {

            var m1 = new Marks(490, 5);
            var s1 = new Student("sravs",20,1,"csbs",m1);
            m1.calcPercentage();
            s1.displayDetails();

        }

    
    }
}
