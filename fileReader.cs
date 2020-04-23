using System;
using System.IO;
using System.Text;

namespace WordCounter
{
    class fileReader
    {
    
        
        public static string Reader(string path)
        {
            StreamReader sr = new StreamReader(path);
            
            return sr.ReadToEnd();
        }
    }
}