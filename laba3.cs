namespace laba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 1, 54, -32, 52, 8232, 64, 9, 10 }; // Створює самий Ліст 

            var newlist = from i in list
                          where i >= 10 && i < 100
                          orderby i
                          select i;

            foreach (var i in newlist)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
