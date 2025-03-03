namespace first_task
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("enter the number of larg carpet");

                int smaleCarpet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number of smale carpet");

                int largeCarpet = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("cost for smale : 25$");

            Console.WriteLine("cost for large : 35$");

            Console.WriteLine("tax is : 6.6%");

            int smaleCost = smaleCarpet * 25;

                   int largCost = largeCarpet * 35;

            Console.WriteLine($"cost of smale carpet is : {smaleCost}");
            Console.WriteLine($" cost of larg carpet is : {largCost}");


            int totalCost = largCost + smaleCost;

            double tax = totalCost * 0.066;

            Console.WriteLine("==============================================================");

            Console.WriteLine($"total cost is :{totalCost}$ ");

            Console.WriteLine($"total taxs is :{tax}$");

            Console.WriteLine("....................Happy time.......................");







            


















        }
    }
}
