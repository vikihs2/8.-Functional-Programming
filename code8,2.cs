string input = Console.ReadLine();
int[] nums = input.Split(", ").Select(int.Parse).ToArray();
int count = nums.Length;
int sum = nums.Sum();
Console.WriteLine(count);
Console.WriteLine(sum);