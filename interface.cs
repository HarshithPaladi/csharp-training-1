using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public interface Iparent
    {
        public void show();
        public void calculate(int age);

        public void display(string name)
        {
            Console.WriteLine("interface "+ name);
        }
    }

    public class child:Iparent
    {
        public void show()
        {
            Console.WriteLine("show method in child");
        }

        public void calculate(int age)
        {
            Console.WriteLine(age);
        }
       

        public static void Main(string[] args)
        {
            child c = new child();
            Iparent p = new child();
            c.show();
            c.calculate(1);
            p.display("sravani");
            p.show();
        }
    }


}
