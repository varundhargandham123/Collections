using System;
using System.Collections;

 namespace CollectionClasses
{
    
    class NormalCollections
    {
        /// <summary>
        /// Represents an ArrayList. 
        /// </summary>
        public void arrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);           
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Clear();
            arrayList.Add(6);
            arrayList.Add(5);
            arrayList.Add(4);
            arrayList.Add(3);
            arrayList.Add(2);
            arrayList.Add(1);           
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Represents a HashTable
        /// </summary>
        public void hashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "one");
            hashtable.Add(2, "two");
            hashtable.Add(3, "three");
            foreach (DictionaryEntry i in hashtable)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }
        }

        /// <summary>
        /// Represents a Stack
        /// </summary>
        public void stack()
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Peek"+" " + stack.Peek());
            Console.WriteLine("Pop" +" "+ stack.Pop());
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Represents a queue
        /// </summary>
        public void queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Peek"+" " + queue.Peek());
            Console.WriteLine("Dequeue"+" " + queue.Dequeue());
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
        }
   }
    class Collections
    {
        public static void Main(string[] args)
        {
           
           NormalCollections normalcollections = new NormalCollections();
            Console.WriteLine("ArrayList");
            normalcollections.arrayList();
            Console.WriteLine("HashTable");
            normalcollections.hashTable();
            Console.WriteLine("Stack");
            normalcollections.stack();
            Console.WriteLine("Queue");
            normalcollections.queue();
        }


    }

}