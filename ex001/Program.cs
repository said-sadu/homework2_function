Console.Clear();
int number = new Random().Next(10, 100);
//Console.WriteLine("number: {number}");
Console.WriteLine($"number: {number}");
int x = number / 10;
int y = number % 10;

if (x>y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}
