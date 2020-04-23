using System;
//TO DO
//Подсчет общего количества слов, самого короткого, самого длинного
namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Ввод адреса");

            string path = @"D:\4.txt";//Console.ReadLine();

            string text = fileReader.Reader(path);

            int count = 0;

            count = Counter.doSomething(text);
            Console.WriteLine(count);
            Console.Read();
        }
    }
}