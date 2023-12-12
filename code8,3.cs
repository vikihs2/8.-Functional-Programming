Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
var words = Console.ReadLine().Split(new string[] { " " },
StringSplitOptions.RemoveEmptyEntries).Where(checker).ToArray();
foreach (string word in words)
{
    Console.WriteLine(word);
}