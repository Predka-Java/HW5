// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int FindSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) {
            sum = sum + arr[i];
        }
    }
    return sum;
}
int[] CrateArray(int size)
{
int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(10);
}
return arr;
}

int[] arr = CrateArray(10);

int sum = FindSum(arr);

Console.WriteLine($"[{(String.Join(" ", arr))}] -> {sum}");
