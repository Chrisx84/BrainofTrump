namespace BrainofTrump
{
    public class BrainofTrump
    {
        public static void Main(string[] args)
        {
            string Country = args.Length > 0 ? args[0] : "Canada";
            if (Country == "Canada")
            {
                Console.WriteLine("I hate Canada because they hate me so I'm going to tariff them and it will be spectacular");
                HateCanada();
            }
            else if (Country == "Mexico")
            {
                Console.WriteLine("Mexico I don't know much about so affective immediately I will deport anyone from Mexico");
                int deportationCount = args.Length > 1 ? int.Parse(args[1]) : 25;
                DeportMexicans(deportationCount);
            }
            else if (Country == "USA")
            {
                Console.WriteLine("The USA is the best country in the world, believe me!");
            }
            else
            {
                Console.WriteLine($"I don't know much about {Country}, but I'm sure it's great and the people love me!");
            }
        }
        private static void HateCanada()
        {
            int tariff = 25;
            for (int i = 0; i < 20; i++)
            {
                tariff = tariff + (i * 2);
                Console.WriteLine($"Tariffing Canada at {tariff.ToString()}%");
            }
        }
        private static void DeportMexicans(int deportationCount)
        {
            for (int i = 0; i < deportationCount; i++)
            {
                Console.WriteLine($"Deporting Mexican {i} of {deportationCount}");
            }
        }
    }
}