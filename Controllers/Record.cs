using System.IO;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace ApiDemo.Controllers
{
    public class Record
    {

        public static void AddRecord(string text)
        {
            string path = "history.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Calculator History");
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(text);
            }
        }

        public static string ReadRecord()
        {
            string path = "history.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Calculator History");
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                //string s = "";
                //while ((s = sr.ReadLine()) != null)
                //{
                //   Console.WriteLine(sr.ReadLine());
                //}                
               
                string readSt = sr.ReadToEnd();
                return readSt;
            }
           
        }

        public static string DeleteRecord()
        {
            string path = "history.txt";

            using (StreamWriter sDelete = File.CreateText(path))
            {
                //string hCleared = "history cleared";
                sDelete.WriteLine("history cleared");
            }
            string stRead = ReadRecord();
            File.Delete(path);
            return stRead;

        }

    }
}
