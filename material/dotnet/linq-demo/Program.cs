List<int> numbers = [1, 2, 3, 4, 5, 6];
// créer une liste qui contient le double des nombres impairs
List<int> resultNumbers = [];
foreach (var n in numbers)
{
  if (n % 2 == 1)
  {
    resultNumbers.Add(n * 2);
  }
}
Console.WriteLine(string.Join(", ", resultNumbers));

bool isOdd(int n) => n % 2 == 0;
Func<int, bool> isOdd2 = n => n % 2 == 1;
var oddNumbers = numbers.Where(n => n % 2 == 1);
var oddNumbers2 = numbers.Where(isOdd2);
var oddNumbers3 = numbers.Where(isOdd);
Console.WriteLine(string.Join(", ", oddNumbers));

var doubleOddNumbers = oddNumbers.Select((n) => n * 2);
Console.WriteLine(string.Join(", ", doubleOddNumbers));

var resultNumbers2 = numbers.Where(n => n % 2 == 1).Select(n => n * 2);
Console.WriteLine(string.Join(", ", resultNumbers2));
// With LINQ, we can add optimisations easily
var resultNumbers3 = numbers.AsParallel()
                            .Where(n => n % 2 == 1)
                            .Select(n => n * 2);