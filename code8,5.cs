string input = Console.ReadLine();
List<int> nums = new List<int>();
foreach (string number in input.Split(' '))
{
    nums.Add(int.Parse(number));
}
Func<List<int>, int> findSmallest = (List<int> nums) =>
{
    int min = nums[0];
    foreach (int num in nums)
    {
        if (num < min)
        {
            min = num;
        }
    }
    return min;
};
int minNum = findSmallest(nums);
Console.WriteLine(minNum);