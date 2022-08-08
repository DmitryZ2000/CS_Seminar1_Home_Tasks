Console.Write("Введите произвольное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
    Console.Write($"Число {number} является четным");
else
    Console.Write($"Число {number} является нечетным");
