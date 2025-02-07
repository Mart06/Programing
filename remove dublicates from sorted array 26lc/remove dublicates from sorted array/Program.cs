using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // идеята е да вземе елементите от масива, да изтрие дубликатите и да отпечати масива без
        // дубликати и да отпечати броя на елементите в преработения масив


        List<int> myList = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
        myList.Sort();
        for (int i = 1; i < myList.Count; i++)
        {
            if (myList[i] == myList[i-1])
            {
                myList.Remove(myList[i]);
            }
        }

        Console.WriteLine(myList.Count);
        Console.WriteLine(string.Join(" ", myList));


        /*
          int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

         Array.Sort(arr);

         for (int i = 0; i < arr.Length; i++)
         {
             if (arr.Contains(arr[i]))
             {
                arr[i] = 0;

             }
         }

         Console.WriteLine(string.Join(" ",arr)); 

        */

        /* ArrayList myList = new ArrayList(Console.ReadLine().Split());

        myList.Sort();

        foreach (var element in myList)
        {
            if (myList.Contains(element))
            {
                myList.Remove(element);
            }
        }       
        
        Console.WriteLine(string.Join(" ", myList));
        */
    }
}