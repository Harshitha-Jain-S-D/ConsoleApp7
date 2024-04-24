using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // ArrayList
        Console.WriteLine("ArrayList Example:");
        ArrayList arrayList = new ArrayList();
        arrayList.Add("Apple");
        arrayList.Insert(1, "Banana");
        arrayList.Add("Orange");
        arrayList.Add("Grapes");

        Console.WriteLine("ArrayList before removing: ");
        PrintArrayList(arrayList);

        arrayList.Remove("Banana");

        Console.WriteLine("ArrayList after removing: ");
        PrintArrayList(arrayList);

        int index = arrayList.IndexOf("Orange");
        Console.WriteLine($"Index of Orange: {index}");

        arrayList.Sort();
        Console.WriteLine("ArrayList after sorting: ");
        PrintArrayList(arrayList);

        // Hashtable
        Console.WriteLine("\nHashtable Example:");
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Key1", "Value1");
        hashtable.Add("Key2", "Value2");
        hashtable.Add("Key3", "Value3");

        Console.WriteLine("Value of Key2: " + hashtable["Key2"]);

        hashtable.Remove("Key3");

        // SortedList
        Console.WriteLine("\nSortedList Example:");
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(2, "Two");
        sortedList.Add(1, "One");

        Console.WriteLine("Value of key 2: " + sortedList[2]);

        sortedList.RemoveAt(1);

        sortedList[2] = "Two (Updated)";

        Console.WriteLine("Sorted list after replacing: ");
        PrintSortedList(sortedList);
    }

    static void PrintArrayList(ArrayList arrayList)
    {
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }

    static void PrintSortedList(SortedList sortedList)
    {
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine("Key: " + entry.Key + ", Value: " + entry.Value);
        }
    }
}