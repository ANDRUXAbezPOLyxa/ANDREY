Console.WriteLine("введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (b*b == a)
{
    Console.WriteLine("первое число " + "[" + a + "]" + " является квадратом второго " + "[" + b + "]");
}
if (b*b != a)
{
    Console.WriteLine("первое число " + "[" + a + "]" + "  не является квадратом второго " + "[" + b + "]");
}