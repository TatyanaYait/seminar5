int size = 7;
int minValue = -9;
int maxValue = 9;
int[] array = new int[size];

int sumI = 0;

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine();

for (int i = 0; i < array.Length; ++i)
{
    if (i % 2 == 1)
    {
        sumI += array[i];
    }
}

Console.WriteLine("сумма элементов с нечетных позиций = " + sumI);
Console.WriteLine();