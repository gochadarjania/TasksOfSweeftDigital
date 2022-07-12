// See https://aka.ms/new-console-template for more information

var array = new int[] { 34, 232, 43, 2, 1, 3, 5, 6, 66, 23 };

Console.WriteLine(NotContains(array));

int NotContains(int[] array)
{
    int minNumber = 0;
    Array.Sort(array);
    for (int i = 0; i < array.Length; i++)
    {
        minNumber++;

        if (array[i]!=minNumber)
        {
            return minNumber;
        }
    }

    return 0;
}