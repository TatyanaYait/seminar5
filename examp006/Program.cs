int size = 7;
int minValue = 0;
int maxValue = 9;
int[] array = new int[size];
int [] array2 = array.Length%2 == 1? new int[array.Length/2+1] : new int[array.Length/2];

for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine();

for (int i = 0; i < array.Length/2; ++i)
{
int pr = array [i]* array[array.Length - (i+1)];
array2[i]=pr;
}
if (array.Length % 2==1)
{
    array2[array2.Length -1] = array [array.Length /2];
}
Console.WriteLine(string.Join(",", array2));
Console.WriteLine();