// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int FindDifference(int[] arr)
{
int min = int.MaxValue;
int max = 0;

for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] >= max) {
        max = arr[i];
    }
    else if(arr[i] <= min) 
    {
        min = arr[i];
    }
    
}
int dif = max - min;
return dif;
}
int[] CrateArray(int size)
{
int[] arr = new int[size];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next();
}
return arr;
}

int[] arr = CrateArray(10);

int dif = FindDifference(arr);


Console.WriteLine($"[{(String.Join(" ", arr))}] -> {dif}");