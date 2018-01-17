using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace StringClassTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text = "Sample Text, Sample Text, Sample all the way";
            Console.WriteLine(new TextTransformer().TransformToUpper(text));
        }
    }
}