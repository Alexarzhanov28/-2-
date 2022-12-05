// Задача 10
Console.Clear();
Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 100 && a < 1000)
{
    int n1 = a % 100;
    int n2 = n1 / 10;
    Console.WriteLine($"Вторая цифра этого числа: {n2}");
}
else
    Console.WriteLine("Что то пошло не так");
