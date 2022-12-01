using System;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };
            ArrayList list3 = new ArrayList();
            ArrayList list4 = new ArrayList(list1);
            ArrayList list5 = new ArrayList(list2);

            for (var i = 0; i < list1.Length; i++)
            {
                for (var j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        list3.Add(list2[j]);
                        list4.Remove(list1[i]);
                        list5.Remove(list2[j]);
                    }
                }
            }

            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they 
            // are contained in both lists.
            Console.WriteLine(string.Join(" ", list3.ToArray()));
           
            //b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            Console.WriteLine(string.Join(" ", list4.ToArray()));

            //c. Complete here
            //Show the elements from list 2, but is not found in list1. E.g 6 7"
            Console.WriteLine(string.Join(" ", list5.ToArray()));
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }

}
