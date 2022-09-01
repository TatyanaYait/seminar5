/*void FillArray(int[] numbA) {
    int length = numbA.Length;
    int index = 0;
    while (index < length)
    {
        numbA[index] = new Random().Next(-9, 10);
        index++;
    }
}
void PrintArray(int[] numbB) {
    int count = numbB.Length;
    int posit = 0;
    while (posit < count)
    {
        Console.Write(numbB[posit]);
        posit++;
    }
}

int[] array = new int[X];
FillArray(array);
PrintArray(array);
Console.WriteLine();*/

int size = 4;
int minValue = -9;
int maxValue = +9;
int[] array = new int[size];
for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));

for (int i = 0; i < array.Length; ++i)
{
       array[i] = array[i]* (-1);
}
Console.WriteLine(string.Join(",", array));
