int[] arr1 = new int[10];

for (int i = 0; i < 10; i++)
{
    arr1[i] = i + 1;
}

for (int i = 0; i < 10; i++)
{
    if (arr1[i] % 2 == 0)
    {
        Console.Write($"{arr1[i]} ");
    }
}
