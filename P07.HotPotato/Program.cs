namespace P07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ").ToArray();
            Queue<string> participants = new Queue<string>(names);

            int count = int.Parse(Console.ReadLine());
            int tosses = 0;

            while (participants.Count > 1)
            {
                string currentPlayer = participants.Dequeue();
                tosses++;
                if (tosses == count)
                {
                    Console.WriteLine($"Removed {currentPlayer}");
                    tosses = 0;
                    continue;
                }
                else
                {
                    participants.Enqueue(currentPlayer);
                }
            }

            Console.WriteLine($"Last is {participants.Dequeue()}");
        }
    }
}