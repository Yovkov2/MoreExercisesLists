using System.Text;

string input = Console.ReadLine();

List<int> numbers = new List<int>();
List<char> nonNumbers = new List<char>();

foreach (char symbol in input)
{
    if (char.IsDigit(symbol))
    {
        numbers.Add(symbol - '0');
    }
    else
    {
        nonNumbers.Add(symbol);
    }
}

List<int> takeList = new List<int>();
List<int> skipList = new List<int>();

for (int i = 0; i < numbers.Count; i++)
{
    if (i % 2 == 0)
    {
        takeList.Add(numbers[i]);
    }
    else
    {
        skipList.Add(numbers[i]);
    }
}

StringBuilder result = new StringBuilder();
int index = 0;

for (int i = 0; i < takeList.Count; i++)
{
    int take = takeList[i];
    int skip = skipList[i];

    for (int j = 0; j < take && index < nonNumbers.Count; j++)
    {
        result.Append(nonNumbers[index]);
        index++;
    }

    index += skip;

    if (index > nonNumbers.Count)
    {
        index = nonNumbers.Count;
    }
}

Console.WriteLine(result);