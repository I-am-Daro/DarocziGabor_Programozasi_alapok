/*
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
*/

WriteFirstNPrime(50);

bool IsPrime(int number)
{
    bool isPrime = true;
    for (int i = 2; i <= number /2; i++ )
    {
        if(number % i ==0) 
        {
            isPrime = false;
        }
    }
    return isPrime;
}

void WriteFirstNPrime(int n)
{
    int found = 0;

    for (int i = 2; found < n; i++) 
    {
        if (IsPrime(i))
        {
            found++;
            Console.WriteLine(found + " " + i);
        }
    }
}
