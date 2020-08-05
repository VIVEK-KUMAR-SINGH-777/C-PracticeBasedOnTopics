using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOpeartion
{
    class Program
    {
        static void Main(string[] args)
        {
            //implementation of linq operation 
            List<int> data = new List<int>()
            { 
                1,2,3,4,5,6,7,8,9
            };
            
            //LINQ Query using Query Syntax  
            var query = from obj in data
                        where obj > 5
                        select obj;
            foreach(var item in  query)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(".........................LINQ Min () Function ..................");

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
            int minimumNum = a.Min();
            Console.WriteLine(minimumNum);

            Console.WriteLine(".........................LINQ Max () Function ..................");
            int maxNum = a.Max();
            Console.WriteLine(maxNum);

            // sum function implementation 
            var query1 = (from obj in data
                        where obj > 5
                        select obj).Sum();
            Console.WriteLine("...........................sum() function implementation ..................");
            Console.WriteLine("Sum is :: "+query1);

            //use of Lambda Expression 
            List<string> country = new List<string>();
            country.Add("India");
            country.Add("USA");
            country.Add("Pakistan");
            country.Add("RUSSIA");
            Console.WriteLine("...............................Lambda Expression Implementation .......................");
            IEnumerable<string> result = country.Select(x => x);  
            foreach(var cou in country)
            {
                Console.WriteLine(cou);
            }

            Console.ReadLine();

        }
    }
}
