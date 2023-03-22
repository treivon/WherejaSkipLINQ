namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            WhereLINQ();
            Skip();

        }
        public static void WhereLINQ()
        {
            var peopleAge = PeopleList.peoples
                .Where(x => x.Age > 11 && x.Age < 35);

            foreach (var people in peopleAge)
            {
                Console.WriteLine(people.Name);
            }
        }

        public static void Skip()
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("--------------Skip--------------");
    
            var skip = PeopleList.peoples.Skip(6);

            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}