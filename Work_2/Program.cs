// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Prompt(string num) 
{
    System.Console.Write (num);

    return int.Parse(Console.ReadLine());
}

int [] RandomArray (int length, int min,int max)
{
    int[] newarray = new int[length];
    Random rand = new Random();
    for (int i = 0;i < newarray.Length; i++)
    {
        newarray[i] = rand.Next(min,max+1);
    }
    return newarray;
}
int Sum (int [] array)
{
    int min = array[0];
    int max = array[0];
    int sum = 0;
    for (int y = 0; y < array.Length; y++)
    {
        //int sum = 0;
        if (y>0 & y%2!=0)
        {
            sum =sum+ array[y];
            y++;
        }
        
    }
    return sum;
    }

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int y = 0; y < array.Length; y++)
    {
        Console.Write("; " + array[y]);
    }
    Console.Write("]");
}

int LengthArray = Prompt("Введите длину массива --> ");
int Min_num = Prompt("Введите начальное число  --> ");
int Max_num = Prompt("Введите конечное число --> ");
int[] array = RandomArray(LengthArray,Min_num,Max_num);
PrintArray(array);
Console.WriteLine($" Сумма чисел, стоящих на нечётных позициях  => {Sum(array)}");

