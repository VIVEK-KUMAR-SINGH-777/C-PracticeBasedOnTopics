using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLLECTIONcomplete
{
    class Program
    {
        static void Main(string[] args)
        {
                    // collection implementation 

            //implementation of list.It can have duplicate elements
            var nam = new List<string>();
            //to add the data in the list(one way to add data)
            nam.Add("vivek kumar");
            nam.Add("rakesh kumar");
            Console.WriteLine("...............List Implementation..............");

            //other way declaration with initialization
            var name = new List<string>() { "raju", "shyam" };

            // for accessing data 
            foreach(var names in name)
            {
                Console.WriteLine(names);
            }

            //SortedList<TKey, TValue> implementation
            SortedList<string, string> SortedListData = new SortedList<string, string>();
            Console.WriteLine("...............SortedList<TKey, TValue> Implementation..............");
            SortedListData.Add("1", "Ravish");
            SortedListData.Add("12", "David");
            SortedListData.Add("13", "kailesh");
            SortedListData.Add("11", "Mona");
            foreach(var sortData in SortedListData)
            {
                Console.WriteLine(sortData);
            }
 
           //  HashSet<T> implementation 
            var hashdata = new HashSet<string>() { "first", "second", "third" };
            Console.WriteLine("...............HashSet Implementation..............");
            foreach (var hashdataAccess in hashdata)
            {
                Console.WriteLine(hashdataAccess);
            }

            // SortedSet<T> implementation 
            var SortedSetData = new SortedSet<string>() { "vivek", "kumar", "Abhishek", "Kamal" };
            Console.WriteLine("...............SortedSet<T> Implementation..............");
            foreach (var sortedsetdata in SortedSetData)
            {
                Console.WriteLine(sortedsetdata);
            }

            // Stack<T> implementation 
            var stackData = new Stack<string>();
            Console.WriteLine("...............Stack<T> Implementation..............");
            stackData.Push("vivek");
            stackData.Push("kumar");
            stackData.Push("Neha");

            Console.WriteLine("Element which is in first position"+stackData.Peek());
            Console.WriteLine("Get Type" + stackData.GetType());



            //Queue<T> implementation 

            Console.WriteLine("...............Queue<T> Implementation..............");
            var QueueData = new Queue<string>();
            QueueData.Enqueue("data1");
            QueueData.Enqueue("data2");
            QueueData.Enqueue("data3");
            QueueData.Dequeue();

            foreach(var data in QueueData)
            {
                Console.WriteLine(data);
            }
            //LinkedList<T> implementation 
            var LinkedListData = new LinkedList<string>();
            Console.WriteLine("...............LinkedList<T> Implementation..............");
            LinkedListData.AddFirst("sonu");
            LinkedListData.AddLast("Monu");
            foreach(var linkdata in LinkedListData)
            {
                Console.WriteLine(linkdata);
            }
            // Dictionary<TKey, TValue> Implementation 
            Dictionary<int, string> Dictdata = new Dictionary<int, string>();
            Console.WriteLine("...............Dictionary<TKey, TValue> Implementation ..............");
            Dictdata.Add(1,"shyam");
            Dictdata.Add(2, "Ravi");
            foreach(var dictdata in Dictdata)
            {
                Console.WriteLine(dictdata);
            }

            //SortedDictionary<TKey, TValue> implementation
            SortedDictionary<string, string> SortedDictData = new SortedDictionary<string, string>();
            Console.WriteLine("...............SortedDictionary<TKey, TValue> Implementation ..............");
            SortedDictData.Add("1", "Shyam");
            SortedDictData.Add("2", "ARUN");
            SortedDictData.Add("3", "rahul");
            foreach(var data in SortedDictData)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();

        }
    }
}
