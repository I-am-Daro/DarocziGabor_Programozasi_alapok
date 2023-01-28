
/*Console.WriteLine("Hello World!");

// Elágazás

int ammo = 10;
bool isInair = false;

if(ammo > 0 && !isInair)
{
    Console.WriteLine("Bum bum");
    ammo--;
}

bool canShoot = ammo > 0 && !isInair;

if(canShoot)
{
    Console.WriteLine("Bum bum");
    ammo--;
}

else
{
    Console.WriteLine("No more ammo");
}

//-----------------------

Console.WriteLine("írj be egy egész számot!");
string line = Console.ReadLine();
int number = int.Parse(line);

Console.WriteLine("A szám duplája:");
Console.WriteLine(number *2);
*/
//------------------------

/*
Console.WriteLine("Írj be egy egész számot!");

string line = Console.ReadLine();
int number = int.Parse(line);
number = number % 2;


if (number > 0)
{
    Console.WriteLine("A szám páratlan");
}
else
{
    Console.WriteLine("A szám páros");
}
*/

//----------------------------------

// Pozitív, Negatív
/*
Console.WriteLine("Írj be egy egész számot!");

string line = Console.ReadLine();
int number = int.Parse(line);

if (number > 0)
{
    Console.WriteLine("Pozitív");
}

else if (number < 0)
{
    Console.WriteLine("Negatív");
}

else
{
    Console.WriteLine("Nulla");
}
*/

//---------------------------------
//Kerek / Nem kerek
/*

Console.WriteLine("Írj be egy egész számot!");

string line = Console.ReadLine();
int number = int.Parse(line);

string text = number % 10 == 0 ? "Kerek" : "Nem kerek";
Console.WriteLine(text);
*/

//----------CIKLUSOK---------------
/*
int i = 1;

while( i <= 100) 
{
    Console.WriteLine(i);
    i++;
}

for(int j = 1; j <= 100; j++)
{
    Console.WriteLine(j);
}
*/

// Feladat: kiírni az első 10 számot ami osztható hárommal

/*
int num = 7;

for (int i=1; i<=(10*num); i++)
{
    Console.WriteLine(i * num);
}
*/

//--------------------------

// Első n olyan természetes szám, ami osztható öttel, de nem osztható 7-tel
/*

Console.WriteLine("Hány számot írjak ki?");
string line = Console.ReadLine();
int n = int.Parse(line);

int x = 5;


for(int i = 1; i <= n; i++)
{
    int numberToWrite = i * x;
    int count = 0;

    if(numberToWrite % 7 !=0)
    {
        Console.WriteLine(numberToWrite);
        count++;
    }
}
*/

//--------------------------

//Írjuk ki a szorzótáblát

/*


using System.Globalization;

for (int a= 1; a<=10; a++)
{
    for (int b = 1; b <= 10; b++)
    {
        int result = a * b;
        Console.WriteLine(a + " * " + b + " = " + result);
    }
}
*/

//---------METÓDUSOK----------------


/*
double f1 = 12.5f;       //ez is floating point szám
double f2 = 3f;

double power1 = Math.Pow(f1, f2);       //hatványozás
double power2 = Math.Pow(45, 11.5);

double f3 = Math.Abs(f1);
*/







