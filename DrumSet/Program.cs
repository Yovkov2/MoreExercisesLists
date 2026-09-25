double money = double.Parse(Console.ReadLine());

List<int> drums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

List<int> initialQuality = new List<int>(drums);

string command;

while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
{
    int power = int.Parse(command);

    for (int i = 0; i < drums.Count; i++)
    {
        drums[i] -= power;

        if (drums[i] <= 0)
        {
           
            double price = initialQuality[i] * 3;

            if (money >= price)
            {
                
                money -= price;
                drums[i] = initialQuality[i];
            }
            else
            {
                
                drums.RemoveAt(i);
                initialQuality.RemoveAt(i);
                i--;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", drums));
Console.WriteLine($"Gabsy has ${money:F2}.");