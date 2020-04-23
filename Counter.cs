using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace WordCounter
{
    class Counter
    {
        public static int doSomething(string text)
        {
            string[] arrText = text.Split(' ');

            return arrText.Length;
        }
    }
}