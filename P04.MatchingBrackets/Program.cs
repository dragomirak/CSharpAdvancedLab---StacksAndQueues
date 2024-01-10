namespace P04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    stack.Push(i);
                    continue;
                }
                else if (expression[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string resultString = expression.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(resultString);
                }
            }

        }
    }
}