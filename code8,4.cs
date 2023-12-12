string input = Console.ReadLine();
string[] names = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
Action<string[]> printNames = (string[] arr) =>
{
    foreach (string name in arr)
    {
        Console.WriteLine(name);
    }
};
printNames(names);
Console.ReadLine();