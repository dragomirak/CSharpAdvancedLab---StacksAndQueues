namespace P08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsToPass = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            Queue<string> passedCars = new Queue<string>();

            string input = Console.ReadLine();
            while (true)
            {
                if (input == "end")
                {
                    Console.WriteLine($"{passedCars.Count} cars passed the crossroads.");
                    return;
                }
                else if (input == "green")
                {
                    int count = 0;
                    while (count < carsToPass && cars.Count > 0)
                    {
                        string currentCar = cars.Dequeue();
                        Console.WriteLine($"{currentCar} passed!");
                        passedCars.Enqueue( currentCar );
                        count++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
        }
    }
}