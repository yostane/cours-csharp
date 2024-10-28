void RunQ1()
{
  void ShowEvenNumbers(List<int> numbers)
  {
    var evenNumbers = from n in numbers where n % 2 == 0 select n;
    Console.WriteLine(string.Join(",", evenNumbers));
  }
  ShowEvenNumbers([1, 2, 3, 4, 5, 6, 7]);
}

void RunQ2()
{
  // Avec la method syntax
  List<int> GetEvenNumbers(List<int> numbers)
  {
    var evenNumbers = numbers.Where(n => n % 2 == 0);
    return evenNumbers.ToList();
  }
  // Avec la query syntax et avec un single statement function
  List<int> GetEvenNumbers2(List<int> numbers) =>
    (from n in numbers where n % 2 == 0 select n).ToList();

  List<int> numbers = [1, 2, 3, 4, 5, 6, 7];
  Console.WriteLine(string.Join(",", GetEvenNumbers(numbers)));
  Console.WriteLine(string.Join(",", GetEvenNumbers2(numbers)));
}

RunQ1();