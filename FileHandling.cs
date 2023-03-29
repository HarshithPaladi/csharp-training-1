using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    internal class FileHandling
    {
        

        public static void Main(string[] args)
        {
            String Path = "C:\\Users\\sravani\\OneDrive\\Desktop\\newfile";

            //DirectoryInfo

            DirectoryInfo Directory = new DirectoryInfo(Path);
            Directory.Delete();

            /*//fileInfo class
            FileInfo fi = new(Path);
            fi.Create();*/
            //FileStream file = new FileStream("C:\\Users\\sravani\\OneDrive\\Desktop\\newfile.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);



            /*using (TextWriter writer = File.CreateText(Path))
            {
                //to write
                writer.WriteLine("using text writer");

                char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
                writer.WriteLine(charArray, 2, 3);

            }

            using(TextReader reader = File.OpenText(Path))
            {
                Console.Write(reader.ReadToEnd());
            }*/

            /*StreamReader reader = new StreamReader(file);

            Console.WriteLine(reader.ReadToEnd());

            reader.Close();
            file.Close();*/


            /*// file.Write(Convert.FromBase64String("this is new file"));
            file.WriteByte(66);

            Stream stream = new MemoryStream();
            String strText = "This is a String that needs to be convert in stream";
            byte[] byteArray = Encoding.UTF8.GetBytes(strText);
            file.Write(byteArray);

            file.Close();
            // over writes 
            //File.WriteAllText("C:\\Users\\sravani\\OneDrive\\Desktop\\newfile.txt", "line usingg file class");
            //appends
            File.AppendAllText("C:\\Users\\sravani\\OneDrive\\Desktop\\newfile.txt", "line usingg file class");*/


        }

    }
}
