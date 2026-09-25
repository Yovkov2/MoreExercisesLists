int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

int middle = arr.Length / 2;

double left = 0;
double right = 0;

for (int i = 0; i < middle; i++)
{
    if (arr[i] == 0)
    {
        left *= 0.8;
    }
    else
    {
        left += arr[i];
    }
}

for (int i = arr.Length - 1; i > middle; i--)
{
    if (arr[i] == 0)
    {
        right *= 0.8;
    }
    else
    {
        right += arr[i];
    }
}

left += arr[middle];
right += arr[middle];

if (left < right)
{
    Console.WriteLine($"The winner is left with total time: {left}");
}
else
{
    Console.WriteLine($"The winner is right with total time: {right}");
}