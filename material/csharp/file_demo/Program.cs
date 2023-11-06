StreamReader sr = new("hello.txt");

Console.WriteLine(sr.ReadLine());
Console.WriteLine(sr.Read());
Console.WriteLine(sr.Read());
Console.WriteLine(sr.Peek());

sr.Close();


using (StreamReader sr2 = new("hello.txt"))
{
  String? line = sr2.ReadLine();
  while (line != null)
  {
    Console.WriteLine($"Ligne récuprée: {line}");
    line = sr2.ReadLine();
  }
}

using (StreamWriter sw = new("test.txt"))
{
  sw.WriteLine("Hello");
  sw.WriteLine("J'aime");
  sw.WriteLine("Le C#");
}

// Raccourci pour lire tout le contenu d'un fichier
String fileContent = File.ReadAllText("test.txt");
Console.WriteLine(fileContent);