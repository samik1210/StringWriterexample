using System;
using System.IO;
using System.Text;

namespace StringWriterexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string text = "hii parag \n" +
                "welcome to my home. \n" +
                "hii samiksha";
            StringBuilder sb = new StringBuilder();  
            StringWriter writer = new StringWriter(sb);  
            writer.WriteLine(text);
            writer.Flush();  
            writer.Close();  
            StringReader reader = new StringReader(sb.ToString()); 
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
    
}
