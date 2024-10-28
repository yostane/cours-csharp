bool IsPalindromeAlgo(string input)
{
  for (int i = 0; i < input.Length / 2; i++)
  {
    if (input[i] != input[input.Length - i - 1])
    {
      return false;
    }
  }
  return true;
}

bool IsPalindromeEz(string input) => string.Join("", input.Reverse()) == input;

List<int> generateRandomIntList(int nb)
{
  List<int> items = [];
  Random r = new();
  for (int i = 0; i < nb; i++)
  {
    items.Add(r.Next(1, 12));
  }
  return items;
}

int ComputeSchtroumpf(List<int> items1, List<int> items2)
{
  int result = 0;
  foreach (var item1 in items1)
  {
    foreach (var item2 in items2)
    {
      result += item1 * item2;
    }
  }
  return result;
}


int ComputeRandomSchtroumpf(int nb1, int nb2)
{
  Random r = new();
  List<int> items1 = generateRandomIntList(nb1);
  List<int> items2 = generateRandomIntList(nb2);
  return ComputeSchtroumpf(items1, items2);
}

int ComputeExampleSchtroumpf()
{
  return ComputeSchtroumpf([4, 8, 7, 12], [3, 6]);
}

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/pair", () => Enumerable.Range(0, 11).Select(n => n * 2));
app.MapGet("/pair/{nb}", (int nb) => Enumerable.Range(0, nb + 1).Select(n => n % 2 == 0));
app.MapGet("/impair/{nb}", (int nb) => Enumerable.Range(0, nb + 1).Select(n => n % 2 != 0));
app.MapGet("/consonnes/{mot}", (string mot) => mot.ToLower().Where(c => !"aiueoy".Contains(c)));
app.MapGet("/longueur/{word}", (string word) => word.Length);


app.MapGet("/palindrome/{word}", (string word) => IsPalindromeAlgo(word) ? "Est un palindrome" : "n'est pas un palindrome");
app.MapGet("/ez/palindrome/{word}", (string word) => IsPalindromeEz(word) ? "Est un palindrome" : "n'est pas un palindrome");
app.MapGet("/schtroumpf/{nb1}/{nb2}", (int nb1, int nb2) => ComputeRandomSchtroumpf(nb1, nb2));
app.MapGet("/example/schtroumpf/", () => ComputeExampleSchtroumpf());

app.Run();

