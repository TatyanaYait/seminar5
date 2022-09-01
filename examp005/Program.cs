int size = 123;
int minValue = 0;
int maxValue = 999;
int[] array = new int[size];

int count = 0;

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine();


for (int i = 0; i < array.Length; ++i)
{
    if (array[i] >= 10 && array[i] < 100) 
    {
        count++;
    }

}
Console.WriteLine("количество элементов в отрезке [10,99] = " + count);
