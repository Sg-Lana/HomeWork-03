/* напишите программу которая задает массив из 8 случайных элементов и выдает 
его на экран*/

int[] NewArray(int len = 8)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,100); 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int[] arrey = NewArray(); 
PrintArray(arrey);