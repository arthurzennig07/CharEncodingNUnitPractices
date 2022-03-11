using System;
using CharEncodingNUnitPractices.Services;

namespace CharEncodingNUnitPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("started");
            var util = new CharEncodeUtility();
            int n = util.intValue('H');
            Console.WriteLine(n);
        }
    }
}