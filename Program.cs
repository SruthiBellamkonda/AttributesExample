using System;
using System.Collections.Generic;
namespace AttributesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            List<int> l = new List<int> {2,7,4,3,4,89,8,9,1000 };
            int s1 = c.Add(2, 3);
            int sum=c.Add(l);
            Console.WriteLine(s1);
            Console.WriteLine(sum);
        }
    }
    public class Calculator
    {
       [ObsoleteAttribute("Please use Add(List<int> Numbers) function instead of Add(int a,int b)"),true]
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int n in Numbers)
                sum = sum + n;
            return sum;
        }
    }

}
