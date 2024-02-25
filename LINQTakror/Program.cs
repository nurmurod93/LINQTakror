int[] numbers =  { 96, 7, 48, 56, 2 };

var numQuery = from num in numbers
               where num % 2 == 0
               select num;
foreach (var num in numQuery)
{
    Console.WriteLine("{0, 1}");
}

int[] arr = { -3, -2, -1, 0, 1, 2, 3 };

IEnumerable<int> numQuery2 = from number in arr where number > 0 select number;

foreach (var num in numQuery2)
{
    Console.WriteLine("{0, 1}", num);
}

int[] array = { 0, 4, 3, 2, 7, 6, 12, 5 };

var evenNumQuery = from number in array
                   where number % 2 == 0
                   select number;
int evenNumCount = evenNumQuery.Count();
Console.WriteLine(evenNumCount + " : Soni");

List<int> numQuery3 = (from number in array
                       where number % 2 == 0
                       select number).ToList();

foreach (var num in numQuery3)
{
    Console.WriteLine("Raqamlar: "+num);
}

var numQuery4 = (from number in array
                where number % 2 == 0
                select number).ToArray();
foreach (var num2 in numQuery4)
{
    Console.WriteLine("Raqamlar2: "+num2);
}
