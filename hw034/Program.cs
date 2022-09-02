int size = 11;
int minValue = 100;
int maxValue = 999;
int[] array = new int[size];

int count = 0;

for (int i = 0; i < array.Length; ++i) {
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine();

for (int i = 0; i < array.Length; ++i) { 
    int ost = array[i] % 2;

    if ( ost == 0)    {
        count ++;
    }
}

Console.WriteLine("количество четных элементов в массиве = " + count);
Console.WriteLine();