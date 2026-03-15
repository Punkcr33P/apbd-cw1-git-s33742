//Commit in first line
int[] numbers = { 1, 2, 3, 4, 5 };
static double GetAverage(int[] nums) => nums.Average();
Console.WriteLine(GetAverage(numbers));
int max = numbers.Max();
Console.WriteLine($"Max number from numbers: {max}");