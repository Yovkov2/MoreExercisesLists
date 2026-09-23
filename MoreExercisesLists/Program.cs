List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string text = Console.ReadLine();

string result = "";

foreach(int number in numbers)
{
    int sum = 0;
    int current = number;

    while (current > 0)
    {
        sum += current % 10;
        current /= 10;
    }
    int index = sum % text.Length;

    result += text[index];

    text = text.Remove(index, 1);
}
Console.WriteLine(result);