int n = 5;
int[] arr = { 1, 2, 3, 4, 5 };
int max = arr[0];
for (int i = 0; i < n; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine(max);

max = arr[0];
foreach (int a in arr)
{
    if (a > max)
    {
        max = a;
    }
}

Console.WriteLine(max);
