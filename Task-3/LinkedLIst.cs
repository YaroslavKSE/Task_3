using System;

namespace Task_3
{
    public class LinkedList
    {
        private LinkedListNode _head;

        public void Add(KeyValuePair pair)
        {
            if (_head == null)
            {
                _head = new LinkedListNode(pair);
                _head.Next = null;
            }
            else
            {
                LinkedListNode toAdd = new LinkedListNode(pair);
                LinkedListNode current = _head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = toAdd;
            }
        }

        public void RemoveByKey(string key)
        {
            if (_head == null) return;
            if (_head.Pair.Key == key)
            {
                _head = _head.Next;
                return;
            }
            
            LinkedListNode current = _head;
            while (current.Next != null)
            {
                if (current.Next.Pair.Key == key)
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            }
        }
        
        public KeyValuePair GetItemWithKey(string key)
        {
            if (_head == null) return null;
            if (_head.Pair.Key == key)
            {
                return _head.Pair;
            }
            LinkedListNode current = _head;
            while (current.Next != null)
            {
                if (current.Next.Pair.Key == key)
                {
                    return current.Pair;
                }
            }
            return null;
        }

        public void PrintAllNodes()
        {
            LinkedListNode current = _head;
            while (current != null)
            {
                Console.Write(current.Pair.Key); Console.Write(" : "); Console.WriteLine(current.Pair.Value); 
                current = current.Next;
            }
        }
    }
    public class KeyValuePair
    {
        public string Key { get; }

        public string Value { get; }

        public KeyValuePair(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }

    public class LinkedListNode
    {
        public KeyValuePair Pair { get;  }

        public LinkedListNode Next { get; set; }

        public LinkedListNode(KeyValuePair pair, LinkedListNode next = null)
        {
            Pair = pair;
            Next = next;
        }
    }
    
}