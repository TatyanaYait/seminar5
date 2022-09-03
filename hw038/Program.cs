Console.WriteLine("Задайте длинну массива: ");
int d = int.Parse(Console.ReadLine());

//double minValue = -9;
//double maxValue = 9;

/*Console.WriteLine("Введите минимальное значение элемента: ");
double mIV = double.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента: ");
double mAV = double.Parse(Console.ReadLine());*/


double[] array = new double[d];
Random rand = new Random();

for (int i = 0; i < array.Length; ++i)
{
    array[i] = rand.Next(-9, 10) + rand.NextDouble();

}
//Console.ReadLine();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

double min = array[0];
double max = array[0];

for (int j = 0; j < array.Length; ++j)
{
    if (max < array[j]) max = array[j];
    if (min > array[j]) min = array[j];
}

Console.WriteLine(max + " - это максимальное число массива");
Console.WriteLine(min + " - это минимальное число массива");
double raznost = max - min;
Console.WriteLine();
Console.WriteLine("разница между максимальным и минимальным элементом в массиве = " + raznost);