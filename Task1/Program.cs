// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int CheckArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] % 2 == 0) {
        count++;
       } 
    }
    return count;
}

int[] CrateArray(int size, int begin, int end )
{
int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(begin, end + 1);
}
return arr;
}

int[] arr = CrateArray(10, 100, 999);
int count = CheckArray(arr);
Console.WriteLine($"[{(String.Join(" ", arr))}] -> {count}");