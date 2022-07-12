// See https://aka.ms/new-console-template for more information

Console.WriteLine(MinSplit(127));

int MinSplit(int amount)
{
    int count = 0;
    int balance = 0;


    if (50 <= amount)
    {
        balance = amount % 50;
        count += (amount - balance) / 50;
        amount -= amount - balance;
    }
    if (20 <= amount)
    {
        balance = amount % 20;
        count += (amount - balance) / 20;
        amount -= amount - balance;
    }

    if (10 <= amount)
    {
        balance = amount % 10;
        count += (amount - balance) / 10;
        amount -= amount - balance;
    }

    if (5 <= amount)
    {
        balance = amount % 5;
        count += (amount - balance) / 5;
        amount -= amount - balance;
    }

    if (1 <= amount)
    {
        balance = amount % 1;
        count += (amount - balance) / 1;
    }


    return count;
}