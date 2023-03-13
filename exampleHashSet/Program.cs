using System;

namespace exampleHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> newHashSet = new HashSet<int>();
            // add items
            newHashSet.Add(1);
            newHashSet.Add(2);
            newHashSet.Add(3);
            newHashSet.Add(4);
            newHashSet.Add(5);
            // new set
            HashSet<int> newNewHashSet = new HashSet<int>();
            newNewHashSet.Add(1);
            newNewHashSet.Add(2);
            newNewHashSet.Add(6);
            newNewHashSet.Add(7);
            newNewHashSet.Add(8);
            // combine and print
            newHashSet.UnionWith(newNewHashSet);
            foreach (int i in newHashSet) Console.WriteLine(i);
            // new dupe hash and display
            HashSet<int> newNewNewHashSet = new HashSet<int>();
            newNewNewHashSet = newHashSet;
            newNewNewHashSet.IntersectWith(newNewHashSet);
            foreach (int i in newNewNewHashSet) Console.WriteLine(i);
        }
    }
}