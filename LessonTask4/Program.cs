Console.WriteLine("введите число");
int n = int.Parse(Console.ReadLine());
if (n % 7 == 0)
{
    int n1 = n % 23;
    if (n1 == 0)
    {
        Console.WriteLine("число " + n + " кратно 7 и 23");
    }    
    if (n1 !=0)
    {
        Console.WriteLine("число " + n + " не кратно 7 и 23");
    }
}  
if (n % 7 !=0)
{
int n2 = n % 23;
    if (n2 !=0)
    {
    Console.WriteLine("число " + n + " не кратно 7 и 23");
    }
    Console.WriteLine("число " + n + " не кратно 7 и 23");
}      

