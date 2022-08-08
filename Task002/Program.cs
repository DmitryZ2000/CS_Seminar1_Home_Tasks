Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
// int a = 53;
// int b = 533;
if (a > b)
    Console.WriteLine($"Число {a} больше");
else if ((a < b))    
    Console.WriteLine($"Число {b} больше");
else 
    Console.WriteLine($"Числа равны");