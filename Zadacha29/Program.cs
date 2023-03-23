// Программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] Massive8()
{
    int n = 8;
    int[] arr = new int[n];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next();
    }
    return arr; 
} 

int[] array = Massive8();

void PrintArray(int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(array);


