// // Напишите программу, которая задаёт массив из
//  8 элементов и выводит их на экран. Сделать через 
//  функции

int [] InputNumber()
{
    int[] array = new int[8];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = rnd.Next(-100,101);
    }
    return array;
}

void PrintArray( int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
    System.Console.Write(array[i] + " ");
   } 
}

int[] result = InputNumber();
 PrintArray(result);

