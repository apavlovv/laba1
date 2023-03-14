using Newtonsoft.Json;

namespace laba2
{
    class Program
    {

        static void Main(string[] args)
        {

            Dictionary<string, string> people = new Dictionary<string, string>();
            Random random = new Random();
            string[] names = { "Вова", "Андрiй", "Саша", "Лєра", "Маша" };
            string[] cities = { "Мiлан", "Дунаiвцi", "Вiнниця", "Полтава", "Дрогобич" };

            for (int i = 0; i < 5; i++)
            {
                people.Add(names[i], cities[random.Next(5)]);
            }

            Console.WriteLine("Список до:");
            foreach (KeyValuePair<string, string> i in people)
            {
                Console.WriteLine(i.Key + " - " + i.Value);
            }

            var sortedKeys = from i in people.Keys
                             orderby i
                             select i;

            Console.WriteLine("\nСписок Пiсля:");
            foreach (var key in sortedKeys)
            {
                Console.WriteLine(key);
            }

            string json = JsonConvert.SerializeObject(people);
            Console.WriteLine(json);
            Console.ReadLine();

        }
    }
}