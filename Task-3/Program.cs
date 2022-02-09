using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList first = new LinkedList();
            first.Add(new KeyValuePair("1", "Hello"));
            first.Add(new KeyValuePair("2", "Hi"));
            first.Add(new KeyValuePair("3", "Buy"));
            first.Add(new KeyValuePair("4", "GoodBuy"));
            first.PrintAllNodes();
            first.RemoveByKey("3");
            first.RemoveByKey("1");
            var a = first.GetItemWithKey("2");
            Console.WriteLine(a.Key);
            Console.WriteLine(a.Value);
            first.PrintAllNodes();
            
        }
    }
}