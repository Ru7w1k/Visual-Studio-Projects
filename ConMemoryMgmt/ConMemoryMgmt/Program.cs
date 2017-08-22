using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConMemoryMgmt
{
    public class FileIO : IDisposable
    {
        private StreamWriter writer;
        private StreamReader reader;

        public void CreateFile()
        {
            writer = new StreamWriter(new FileStream(@"D:\Visual Studio Projects\temp.txt", FileMode.Create));
        }

        public void WriteToFile()
        {
            if(writer != null)
            {
                writer.WriteLine("This is some demo text.");
                writer.WriteLine("One more line.");
                writer.Flush();
                writer.Close();
            }
        }

        public void ReadFromFile()
        {
            reader = new StreamReader(new FileStream(@"D:\Visual Studio Projects\temp.txt", FileMode.Open));
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }

        public void Dispose()
        {
            Console.WriteLine("Inside Dispose");
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                GC.SuppressFinalize(this);
            }
            
            if (writer != null)
            {
                writer.Dispose();
                Console.WriteLine("Writer Disposed");
            }

            if (reader != null)
            {
                reader.Dispose();
                Console.WriteLine("Reader Disposed");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            FileIO fileIO = new FileIO();
            fileIO.CreateFile();
            fileIO.WriteToFile();
            fileIO.ReadFromFile();

            Console.ReadLine();
        }
    }
}
