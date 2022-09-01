
int size = 7;
int minValue = 0;
int maxValue = 9;
int[] array = new int[size];

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int flag = 0;

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));

for (int i = 0; i < array.Length; ++i)
{
    if (array[i] == n) flag = 1;
}

if (flag == 1) Console.WriteLine(" такой элемент в массиве ЕСТЬ!");
if (flag == 0) Console.WriteLine(" такого элемента в массиве НЕТ!");

