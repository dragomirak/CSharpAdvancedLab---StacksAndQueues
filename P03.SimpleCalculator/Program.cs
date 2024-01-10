namespace P03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine().Split(" ").Reverse().ToArray();
            Stack<string> strings = new Stack<string>();

            foreach (string s in expression)
            {
                strings.Push(s);
            }

            int sum = int.Parse(strings.Pop());
            while (strings.Count > 0)
            {
                string currentString = strings.Pop();
                if (currentString == "+")
                {
                    sum += int.Parse(strings.Pop());
                    continue;
                }
                else if (currentString == "-")
                {
                    sum -= int.Parse(strings.Pop());
                    continue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}