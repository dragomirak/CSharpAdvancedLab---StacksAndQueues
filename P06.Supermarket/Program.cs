namespace P06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();
            while (true)
            {
                if (input == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    return;
                }
                else if (input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }

                input = Console.ReadLine();
            }

        }
    }
}