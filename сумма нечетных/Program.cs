//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}
void FindSums(int [] array )
{
    int Sumodd  = 0; 
    for (int i=0; i< array.Length; i++)
    if (i % 2 != 0)
    Sumodd += array [i]; 
    Console.WriteLine($" -> {Sumodd}");

}
void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
}
int[] array = new int[4];
FillArray(array);
PrintArray(array);
FindSums(array);

