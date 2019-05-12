using System;
using System.IO;
using System.Text;

namespace WorkOfFiles
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to WorkOfFiles");
            #region insert in file
            //Console.Write("Please enter your login: ");
            //WriteInFile(Console.ReadLine(), "login.txt");
            #endregion
            ReadFile("login.txt");
            Console.ReadKey();

        }

        private static void WriteInFile(string text, string path)
        {
            using (var sw = new StreamWriter(path, true, Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
        }

        private static bool ReadFile(string path)
        {
            using(var rs = new StreamReader(path, Encoding.UTF8))
            {
                while (!rs.EndOfStream)
                {
                    var login = rs.ReadLine();
                    if("Mironov" == login)
                    {
                        Console.WriteLine("The Find: "+ login);
                    }
                }
               
            }
            return true;
        }
    }
}
