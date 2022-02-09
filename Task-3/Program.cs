using System;
using System.Collections.Generic;

namespace Task_3
{
    internal static class Program
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
            
            
            int CalculateHash(string key)
            {
                var keys = key.ToCharArray();
                var hashcode = 0;
                foreach (var variable in keys)
                {
                    if (variable >= '7')
                    {
                        var byteChar = (byte)variable;
                        var hash = ((byteChar * byteChar) ^ 2  / byteChar - byteChar * 3) ^ 27 - 12345;
                        hashcode += hash;   
                    }
                    else if (variable < '7' && variable > '4')
                    {
                        var byteChar = (byte) variable;
                        var hash = ((byteChar * byteChar) ^ 5 / byteChar - byteChar * 10) ^ 3 - 4321;
                        hashcode += hash;
                    }
                    else
                    {
                        var byteChar = (byte) variable;
                        var hash = ((byteChar * byteChar) ^ 5 / byteChar - byteChar * 12) ^ 3 - 8921;
                        hashcode += hash;   
                    }
                }
                return hashcode;
            }
            Console.WriteLine(CalculateHash("30"));
            Console.WriteLine(CalculateHash("30"));
            Console.WriteLine(CalculateHash("70"));
            Console.WriteLine(CalculateHash("2"));
            Console.WriteLine(CalculateHash("3"));
            Console.WriteLine(CalculateHash("5"));
            Console.WriteLine(CalculateHash("0"));

            
        }
    }
}