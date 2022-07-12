// See https://aka.ms/new-console-template for more information
Console.WriteLine(IsProperly("(()())"));


bool IsProperly(string sequence)
{
    Stack<char> array = new Stack<char>();

    if (sequence.Length % 2 == 1)
    {
        return false;
    }

    for (int i = 0; i < sequence.Length; i++)
    {
        if (sequence[i] == '(')
            array.Push(sequence[i]);

        if (sequence[i] == ')')
        {
            if (array.Count == 0)
            {
                return false;
            }
            else if (array.Pop() != '(' && sequence[i] != ')')
            {
                return false;
            }
        }
    }

    if (array.Count == 0)
    {
        return true; 
    }
    else
    {
        return false;
    }
}