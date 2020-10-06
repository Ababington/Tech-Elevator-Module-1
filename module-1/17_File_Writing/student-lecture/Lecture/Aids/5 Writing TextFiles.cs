using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {

            string directory = Environment.CurrentDirectory;
            string fileName = "output.txt";
            string fullPath = Path.Combine(directory, fileName);
            try
            {
                //create new stream writer
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(DateTime.UtcNow);

                    sw.Write("Hello ");
                    sw.Flush();
                    sw.Write("World");
                    sw.WriteLine("");
                }
            } catch
            {

            }
            // After the using statement ends, file has now been written
            // and closed for further writing
        }



    }
}
