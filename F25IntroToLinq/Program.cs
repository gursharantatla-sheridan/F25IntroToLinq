namespace F25IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 6, 7, 8, 2, 1, 5, 6, 7, 4, 8, 9 };

            // query syntax
            var greaterThan4 = (from n in array
                               where n > 4
                               orderby n
                               select n).ToList();

            // method syntax
            greaterThan4 = array.Where(n => n > 4).OrderByDescending(n => n).ToList();

            Console.WriteLine("Total items: " + greaterThan4.Count);
            foreach (var i in greaterThan4)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("ruBY");
            colors.Add("grEEn");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let colorUppercase = c.ToUpper()
                              where colorUppercase.StartsWith("R")
                              orderby colorUppercase
                              select colorUppercase;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUsT");
            colors.Add("PiNk");


            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");
        }
    }
}
