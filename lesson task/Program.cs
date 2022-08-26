int number = new Random().Next(10,100);
int a1 = number / 10;
int a2 = number % 10;
int max = a1;
if (a2 > max)
{
    max= a2;
}
Console.WriteLine("Максимальная цифра в числе" + number + "=>" + max);