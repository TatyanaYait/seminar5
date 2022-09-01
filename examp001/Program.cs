int[] arr = new int[3];
arr[0] = 1;
arr[1] = 5;
arr[2] = 38;

string concat = MyJoin(",", arr);
Console.WriteLine(concat);

string MyJoin(string delimiter, int[] array)
{
    string res = "";
    for (int i = 0; i < array.Length - 1; ++i)
    {
        res = res + array[i] + delimiter;
    }
    res = res + array[array.Length - 1];
    return res;

Console.WriteLine(res);
}