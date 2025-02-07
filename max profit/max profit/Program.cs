internal class Program
{
    private static void Main(string[] args)
    {
        findMaxProfit();

        int findMaxProfit()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); // 5 2 4 7 1   maxpr= 7-2 = 5
            int maxProfit = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = ++i; j < arr.Length; j++)
                {
                    if ((arr[j] - arr[i]) > maxProfit)
                    {
                        maxProfit = arr[j] - arr[i];
                    }
                }
            }
            Console.WriteLine($"Max profit: {maxProfit}");
            return maxProfit;            
        }        
    }
}