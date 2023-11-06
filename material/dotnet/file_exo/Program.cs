static void PrintCountPerLine(String filePath)
{
  using StreamReader sr = new(filePath);
  String? line = sr.ReadLine();
  while (line != null)
  {
    Console.WriteLine(line.Length);
    line = sr.ReadLine();
  }
}

static void AddDotIfNotPresent(String filePath)
{
  using StreamReader sr = new(filePath);
  using StreamWriter sw = new("dotted_file.txt");
  String? line = sr.ReadLine();
  while (line != null)
  {
    if (!line.EndsWith('.'))
    {
      line += '.'; // autre façon: line = $"{line}.";
    }
    sw.WriteLine(line);
    line = sr.ReadLine();
  }
}



String filePath = "input_file.txt";
PrintCountPerLine(filePath);
AddDotIfNotPresent(filePath);