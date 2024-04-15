// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int currentHour = 15;
if (currentHour >= 11 && currentHour <= 15)
{
    Console.WriteLine("time for luch");

}
Console.WriteLine();

for (int i = 0; i < 11; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();
int count = 5;
while (count > 0)
{
    Console.WriteLine(count);
    count--;
}
Console.WriteLine();

string[] daysOfWeek = { "monday", "tuesday", "wednsday", "thursday" };
foreach(string day in daysOfWeek)
{
    Console.WriteLine(daysOfWeek);
}
Console.WriteLine();


int[] numbers = { 12, 12, 12, 12 };
int sum = 0;
foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine("Sum of numbers = " + sum);