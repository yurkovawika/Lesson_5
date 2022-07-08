// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int Prompt(string length) 
{
    System.Console.Write (length);

    return int.Parse(Console.ReadLine());
}

int SumDigits_2(int numberA)
{
    Random rand = new Random();
    int[] array = new int[numberA];
    int count = 0;
    Console.Write("[");
   for (int y = 0; y < numberA; y++)
    {
        array[y] = rand.Next(100,999);
        Console.Write(" " + array[y]);
        if (array[y]%2==0)
        {
            count ++;
        }
    }
    return count;
}
int num = Prompt("Введите колличество чисел в массиве --> ");
int result = SumDigits_2(num);
System.Console.WriteLine($"] Количество четных чисел в массиве =>  {result}");