int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(nums, CustomCompare);
Console.WriteLine(string.Join(" ", nums));
static int CustomCompare(int a, int b)
{
    if (a % 2 == 0 && b % 2 == 0)
    {
        return a.CompareTo(b);
    }
    else if (a % 2 != 0 && b % 2 != 0)
    {
        return a.CompareTo(b);
    }
    else
    {
        return a % 2 == 0 ? -1 : 1;
    }
}