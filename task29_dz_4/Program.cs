// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int [8];
Random rand = new Random();

for (int index = 0; index < array.Length; index++)
{
    array[index] = rand.Next();
}

for (int index = 0; index < array.Length; index++)
{
    System.Console.Write(array[index] + ", ");
}
