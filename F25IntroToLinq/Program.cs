using ConsoleTables;

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



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Green", 5000),
                new Employee("Anne", "Blue", 6000),
                new Employee("Mark", "Indigo", 4000),
                new Employee("Mary", "White", 5500),
                new Employee("Alice", "Indigo", 7000),
                new Employee("Bob", "Brown", 3000)
            };

            foreach (var emp in employees)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var between4k6k = from e in employees
                              where e.Salary >= 4000 && e.Salary <= 6000
                              select e;

            foreach (var emp in between4k6k)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var sortedEmps = from e in employees
                             orderby e.LastName, e.FirstName
                             select e;

            foreach (var emp in sortedEmps)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var lastnames = from e in employees
                            select e.LastName;

            foreach (var emp in lastnames.Distinct())
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");



            var empNames = from e in employees
                           select new { e.FirstName, Last = e.LastName };

            //empNames = employees.Select(e => new { e.FirstName, e.LastName});

            foreach (var emp in empNames)
                Console.WriteLine(emp);
            Console.WriteLine("\n\n");


            // consoletables example
            var table = new ConsoleTable("First name", "Last name", "Salary");

            foreach (var e in employees)
                table.AddRow(e.FirstName, e.LastName, e.Salary.ToString("C"));

            table.Write(Format.MarkDown);
            Console.WriteLine("");
        }
    }
}
