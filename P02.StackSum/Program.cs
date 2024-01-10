namespace P02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> digits = new Stack<int>();

            foreach (int number in numbers)
            {
                digits.Push(number);
            }

            string input;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] instructions = input.Split(" ");
                string command = instructions[0];
                int firstNum = int.Parse(instructions[1]);

                if (command == "add")
                {
                    int secondNum = int.Parse(instructions[2]);
                    digits.Push(firstNum);
                    digits.Push(secondNum);
                }
                else if (command == "remove")
                {
                    if (digits.Count < firstNum)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < firstNum; i++)
                        {
                            digits.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {digits.Sum()}");
        }
    }
}