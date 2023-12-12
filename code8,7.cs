List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
int divider = int.Parse(Console.ReadLine());
nums.Reverse();
nums.RemoveAll(IsDivisibleBy(divider));
Console.WriteLine(string.Join(" ", nums));
static Predicate<int> IsDivisibleBy(int divider)
{
    return x => x % divider == 0;
}