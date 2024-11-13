using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Pratik");
            list.Add("Rohit");
            list.Add("Yash");

            foreach(string s in list)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------------");

            Stack<string> stack = new Stack<string>();
            stack.Push(list[0]);
            stack.Push(list[1]);
            stack.Push(list[2]);

            foreach (string s in list) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("----------------------------------");

            Queue<double> q = new Queue<double>();
            q.Enqueue(1.5);
            q.Enqueue(2.5);

            Console.WriteLine("----------------------------------");

            Dictionary<int , string>dist= new Dictionary<int , string>();
            dist.Add(91, "India");
            dist.Add(81, "USA");

            foreach(KeyValuePair<int , string>item in dist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
