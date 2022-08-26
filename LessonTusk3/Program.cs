Console.WriteLine("введите первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int n2 = int.Parse(Console.ReadLine());
if (n1 % n2 == 0)
{
Console.WriteLine("число " + n2 + " кратно " + n1);
}
else
{
int n3 = n1 % n2;
Console.WriteLine("число " + n2 + " не кратно " + n1 + " остаток " + n3);
}