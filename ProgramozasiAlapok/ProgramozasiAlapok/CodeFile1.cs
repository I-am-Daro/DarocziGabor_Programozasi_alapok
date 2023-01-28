double x = Math.Pow(3, 5);

float y = Math.Abs(-4);

float z = Abs(4);

float Abs(float input)
{
    if (input < 0)
        input = input * -1;
    return input;
}

WriteCounting(10);
WriteCounting(5);
WriteCounting(16);

void WriteCounting(int n)
{
    for (int i = 0; i < n; i++ )
    {
        Console.WriteLine(i);
    }
}

