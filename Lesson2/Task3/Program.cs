//Task2
int n = 10;

int[] array = {1,4,3,8,5,12,7,16,9,20};

int i = 0;

while (i < n)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }

    i = i + 1;
}
