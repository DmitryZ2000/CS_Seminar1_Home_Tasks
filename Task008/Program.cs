Console.Write("Введите произвольное целое число больше 1: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index < number)
{
    Console.Write($"{index}  ");
    index = index + 2;
}