///Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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
        //Console.Write(" " + array[i]);
        
    }
    return newarray;
}
int Max_Min (int [] array)
{
    int min = array[0];
    int max = array[0];
    
    for (int i =1;i < array.Length;i++)
        {
           if(array[i] < min )
           {
            min=array[i];
           }
           if(max < array[i])
           {
            max=array[i];
           }
        }
    int difference = max-min;
    return difference;
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
Console.WriteLine($"--> Разница между максимальным и минимальным элементом массива = {Max_Min(array)} ");

