void RunQ1()
{
  void ShowEvenNumbers(List<int> numbers)
  {
    var evenNumbers = from n in numbers where n % 2 == 0 select n;
    Console.WriteLine(string.Join(",", evenNumbers));
  }
  Console.WriteLine("Exercise 1");
  ShowEvenNumbers([1, 2, 3, 4, 5, 6, 7]);
  // Enumerable.Range equivalent of Python range with less features
  ShowEvenNumbers(Enumerable.Range(-10, 20).ToList());
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

  List<int> numbers = Enumerable.Range(1, 10).ToList();
  Console.WriteLine("Exercise 2");
  Console.WriteLine(string.Join(",", GetEvenNumbers(numbers)));
  Console.WriteLine(string.Join(",", GetEvenNumbers2(numbers)));
}

void RunQ3()
{
  string GetConsonants(string input)
  {
    string lowerCased = input.ToLower();
    var consonants = lowerCased.Where(c => !"aeiuyo".Contains(c));
    return string.Join("", consonants);
  }

  string GetConsonants2(string input) =>
    string.Join("", input.ToLower().Where(c => !"aeiuyo".Contains(c)));
  Console.WriteLine("Exercise 3");
  Console.WriteLine(GetConsonants("Hello"));
  Console.WriteLine(GetConsonants("BBBBCCCC"));
  Console.WriteLine(GetConsonants("aeae"));
  Console.WriteLine(GetConsonants2("Hello"));
  Console.WriteLine(GetConsonants2("BBBBCCCC"));
  Console.WriteLine(GetConsonants2("aeae"));
}

RunQ1();
RunQ2();
RunQ3();