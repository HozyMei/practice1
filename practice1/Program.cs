using System;
using System.Collections.Generic;


namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MainConsole.PrintInfo();
            Parsing parser = new Parsing();
            string filePath = "C:\\Users\\toha3\\OneDrive\\Рабочий стол\\practice1\\practice1\\files.json";
            List<FileDescription> files = parser.ParseJsonFile(filePath);
            MainConsole.PrintInfo(files);
        }
    }
}
