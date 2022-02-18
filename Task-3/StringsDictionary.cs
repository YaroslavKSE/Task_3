using System;

namespace Task_3
{
    public class StringsDictionary
    {
        private static int _initialsize = 500;
        private LinkedList[] _buckets = new LinkedList[_initialsize];
        private int load;
        private double Loadfactor;
        public void Add(string key, string value)
        {
            // var hashCode = Math.Abs(CalculateHash(key));
            var hashCode = Math.Abs(key.GetHashCode());
            var index = hashCode % _initialsize;
            var toAdd = new KeyValuePair(key, value);
            var head = _buckets[index];
            if (head == null)
            {
                _buckets[index] = new LinkedList();
                _buckets[index].Add(toAdd);
                load += 1;
            }
            else
            {
                _buckets[index].Add(toAdd);
                load += 1;
            }
            
            CheckLoadfactor();
        }
        
        public void Remove(string key)
        {
            var hashCode = Math.Abs(key.GetHashCode());
            var index = hashCode % _initialsize;
            var head = _buckets[index];
            if (head == null)
            {
                return;
            }
            head.RemoveByKey(key);

        }

        public string Get(string key)
        {
            // var hashCode = Math.Abs(CalculateHash(key));
            var hashCode = Math.Abs(key.GetHashCode());
            var index = hashCode % _initialsize;
            var head = _buckets[index];
            if (head == null)
            {
                return "Not such letter";
            }

            if (head.GetHead() != null)
            {
                var current = head.GetHead();
                while (current.Pair.Key != key)
                {
                    current = current.Next;
                    if (current == null)
                    {
                        break;
                    }
                }

                if (current.Pair.Key == key)
                {
                    var result = current.Pair.Value;
                    return result;
                }
            }

            return "Not such letter";
           
        }

        public void PrintBuckets()
        {
            foreach (var bucket in _buckets)
            {
                if (bucket == null)
                {
                    continue;   
                }
                bucket.PrintAllNodes();
            }
        }

       

        private void CheckLoadfactor()
        {
            Loadfactor = load / _initialsize;
            if (Loadfactor >= 0.7)
            {
                var newSize = _initialsize * 2;
                _initialsize = newSize;
                LinkedList[] newBuckets = new LinkedList[newSize];
                foreach (var element in _buckets)
                {
                    if (element == null)
                    {
                        continue;
                    } 
                    var current = element.GetHead();
                    while (current != null)
                    {
                        var hashCode = Math.Abs(current.Pair.Key.GetHashCode());
                        var index = hashCode % _initialsize;
                        var head = newBuckets[index];
                        var toAdd = current.Pair;
                        if (head == null)
                        {
                            newBuckets[index] = new LinkedList();
                            newBuckets[index].Add(toAdd);
                            load += 1;
                        }
                        else
                        {
                            newBuckets[index].Add(toAdd);
                            load += 1;
                        }

                        current = current.Next;
                    }
                }

                _buckets = newBuckets;
                load = 0;

            } 
        }

        private int CalculateHash(string key)
        {
            var keys = key.ToCharArray();
            var hashcode = 0;
            foreach (var variable in keys)
            {
                if (variable >= '7')
                {
                    var byteChar = (byte) variable;
                    var hash = ((byteChar * byteChar) ^ 2 / byteChar - byteChar * 3) ^ 9 - 12345;
                    hashcode += hash;
                }
                else if (variable < '7' && variable > '4')
                {
                    var byteChar = (byte) variable;
                    var hash = ((byteChar * byteChar) ^ 5 / byteChar - byteChar * 10) ^ 7 - 4321;
                    hashcode += hash;
                }
                else
                {
                    var byteChar = (byte) variable;
                    var hash = ((byteChar * byteChar) ^ 5 / byteChar - byteChar * 12) ^ 8 - 8921;
                    hashcode += hash;
                }
            }

            return hashcode;
        }
    }
}