﻿//Task2
int n = 10;

int[] array = {1,3,5,7,4,8,11,9,35,19};

int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }

    i = i + 1;
}
