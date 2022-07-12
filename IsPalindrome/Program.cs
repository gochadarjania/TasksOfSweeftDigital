// See https://aka.ms/new-console-template for more information

Console.WriteLine(IsPalindrome("goog"));



static bool IsPalindrome(string n)
{
    return n == Reverse(n);
}

static string Reverse(string str)
{
    return new string(str.ToCharArray().Reverse().ToArray());
}
