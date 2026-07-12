namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estimate for carpet cleaning service");

            Console.Write("Number of small carpets: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of large carpets: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Price per small carpet: {25:C}");
            Console.WriteLine($"Price per large carpet: {35:C}");

            int cost = (number1 * 25) + (number2 * 35);
            Console.WriteLine($"Cost: {cost:C}");

            double tax = cost * 0.06;
            Console.WriteLine($"Tax: {tax:C}");

            double total = cost + tax;
            Console.WriteLine($"Total estimate: {total:C}");

            Console.WriteLine("This estimate is valid for 30 days.");
        }
    }
}
