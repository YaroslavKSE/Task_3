using System;

namespace Task_3
{
    public class StringsDictionary
    {
        private const int Initialsize = 20;
        private LinkedList[] buckets = new LinkedList[Initialsize];

        public void Add(string key, string value)
        {
            
        }

        public void Remove(string key)
        {
            
        }

        public string Get(string key)
        {
            return null;
        }

        private int CalculateHash(string key)
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
    }
    
}