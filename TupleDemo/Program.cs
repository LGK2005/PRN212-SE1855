// See https://aka.ms/new-console-template for more information

int[] ints = { 1, 2, 3, 4, 5 };
(int s, double avg) result = SumAndAverage(ints);
Console.WriteLine($"Sum: {result.s}, Average: {result.avg}");

(int, double) SumAndAverage(params int[] arr)
{
    int sum = 0;
    double average = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    if (arr.Length > 0)
        average = (double)sum / arr.Length;
    return (sum, average);
}