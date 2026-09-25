List<int> firstList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

List<int> secondList = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> mixedList = new List<int>();

int minLength = Math.Min(firstList.Count, secondList.Count);

for (int i = 0; i < minLength; i++)
{
    mixedList.Add(firstList[i]);
    mixedList.Add(secondList[secondList.Count - 1 - i]);
}

List<int> remaining = new List<int>();

if (firstList.Count > secondList.Count)
{
    for (int i = minLength; i < firstList.Count; i++)
    {
        remaining.Add(firstList[i]);
    }
}
else
{
    for (int i = minLength; i < secondList.Count; i++)
    {
        remaining.Add(secondList[i]);
    }
}

int lowerBound = Math.Min(remaining[0], remaining[1]);
int upperBound = Math.Max(remaining[0], remaining[1]);

List<int> result = mixedList
            .Where(x => x >= lowerBound && x <= upperBound)
            .OrderBy(x => x)
            .ToList();

Console.WriteLine(string.Join(" ", result));