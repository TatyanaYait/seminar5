int size = 12;
int minValue = -9;
int maxValue = +9;
int[] array = new int[size];
for (int i = 0; i < array.Length; ++i)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
Console.WriteLine(string.Join(",", array));
int negativeSum = 0;   
int positiveSum = 0;
 
foreach (int el in array)
{
    //negativeSum += el < 0? el : 0;
    //positiveSum += el >0 ? el : 0;
    
    if (el < 0)
    {
        negativeSum += el;
    }
    else
    {
        positiveSum += el;
    }
}
Console.WriteLine("сумма положительных чисел = " + positiveSum);
Console.WriteLine("сумма отрицательных чисел = " + negativeSum);
