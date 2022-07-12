// See https://aka.ms/new-console-template for more information
Console.WriteLine(CountVariants(6));

int CountVariants(int stairCount)
{
    var variantsArray = new List<int>() { 0 };
    int number = 1;

    if (stairCount < 2)
    {
        return 1;
    }

    for (int i = 2; i <= stairCount + 2; i++)
    {
        variantsArray.Add(number);
        number = variantsArray[i - 1] + variantsArray[i - 2];
    }
    return variantsArray.Last();
}




