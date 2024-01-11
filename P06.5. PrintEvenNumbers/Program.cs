namespace P06._5._PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            int queueCount = queue.Count;

            while (queueCount > 0)
            {
                int currentNum = queue.Dequeue();
                queueCount--;
                if (currentNum % 2 != 0)
                {
                    continue;
                }
                else
                {
                    queue.Enqueue(currentNum);
                }
            }

            Console.Write(string.Join(", ", queue));
        }
    }
}