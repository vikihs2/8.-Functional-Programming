string[] input = Console.ReadLine().Split(' ');
int firstNumber = int.Parse(input[0]);
int secondNumber = int.Parse(input[1]);
string operation = Console.ReadLine().ToLower();
Predicate<int> filterPredicate = null;
if (operation == "even")
{
    filterPredicate = IsEven;
}
else if (operation == "odd")
{
    filterPredicate = IsOdd;
}
int[] result = PerformOperation(firstNumber, secondNumber, filterPredicate);
Console.WriteLine(string.Join(' ', result));
static int[] PerformOperation(int firstNumber, int secondNumber, Predicate<int> filterPredicate)
{
    int count = 0;
    for (int i = Math.Min(firstNumber, secondNumber); i <= Math.Max(firstNumber, secondNumber); i++)
    {
        if (filterPredicate == null || filterPredicate(i))
        {
            count++;
        }
    }
    int[] result = new int[count];
    int index = 0;
    for (int i = Math.Min(firstNumber, secondNumber); i <= Math.Max(firstNumber, secondNumber); i++)
    {
        if (filterPredicate == null || filterPredicate(i))
        {
            result[index] = i;
            index++;
        }
    }
    return result;
}
static bool IsEven(int number)
{
    return number % 2 == 0;
}
static bool IsOdd(int number)
{
    return number % 2 != 0;
}