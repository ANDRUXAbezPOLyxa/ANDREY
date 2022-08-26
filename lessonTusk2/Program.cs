int n = new Random().Next(100,1000);
int a1 = n / 100;
int a2 = n % 100;
int b1 = a2 % 10;
Console.Write("число" + n + "преобразуется в =>" + a1 + b1);
