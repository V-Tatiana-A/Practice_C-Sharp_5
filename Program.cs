//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();

WriteLine("Задача 34");
Write("Введите размер массива:  ");
int length=int.Parse(ReadLine()!);

int[] Array=GetArray(length);
WriteLine($"[{String.Join(", ", Array)}]");

CountEven(Array);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

WriteLine("");
WriteLine("Задача 36");
Write("Введите размер массива:  ");
int len=int.Parse(ReadLine()!);
Write("Введите мин значение массива:  ");
int min=int.Parse(ReadLine()!);
Write("Введите макс значение массива:  ");
int max=int.Parse(ReadLine()!);

int[] Array2=GetSecondArray(len, min, max);
WriteLine($"[{String.Join(", ", Array2)}]");

WriteLine($"Сумма элементов, стоящих на нечетных позициях в этом массиве, равна {SumOfOddInd(Array2)}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

WriteLine("");
WriteLine("Задача 38");
Write("Введите размер массива:  ");
int leng=int.Parse(ReadLine()!);
Write("Введите мин значение массива:  ");
double minimum=Convert.ToDouble(ReadLine()!);
Write("Введите макс значение массива:  ");
double maximum=Convert.ToDouble(ReadLine()!);

double[] Array3=GetThirdArray(leng, minimum, maximum);
WriteLine($"[{String.Join(", ", Array3)}]");

WriteLine($"Разность максимального и минимального элементов массива равна {DifferenceMaxMin(Array3):f2}");



// methods

int[] GetArray (int size)
{
    Random rnd=new Random();
    int[] result=new int[size];
    for(int i=0;i<result.Length;i++)
    {
        result[i]=rnd.Next(100, 1000);
    }
    return result;
}

void CountEven(int[] ArrayOrigin)
{
    int result=0;
    foreach (int item in ArrayOrigin)
    {
        if (item%2==0) result=result+1;
    }

    WriteLine($"В заданном массиве {result} четных чисел");
}

int[] GetSecondArray (int size2, int minValue, int maxValue)
{
    Random rnd=new Random();
    int[] result=new int[size2];
    for(int i=0;i<size2;i++)
    {
        result[i]=rnd.Next(minValue,maxValue+1);
    }
    return result;
}

int SumOfOddInd(int [] ArrayToSum)
{
    int result=0;
    for(int i=0;i<ArrayToSum.Length;i++)
    {
        if(i%2!=0) result=result+ArrayToSum[i];
    }
    return result;
}

double[] GetThirdArray (int size3, double minimumValue, double maximumValue)
{
    Random rnd=new Random();
    double[] result=new double[size3];
    for(int i=0;i<size3;i++)
    {
        // result[i]=rnd.Next(minimumValue,maximumValue+1);
        result[i] = Math.Round((minimumValue + rnd.NextDouble()*(maximumValue-minimumValue)),2);
    }
    return result;
}

double DifferenceMaxMin(double[] ArrayToSearch)
{
    double biggest=ArrayToSearch[0];
    double smallest=ArrayToSearch[0];
    for(int i=1;i<ArrayToSearch.Length;i++)
    {
        if(ArrayToSearch[i]<smallest) smallest=ArrayToSearch[i];
        if(ArrayToSearch[i]>biggest) biggest=ArrayToSearch[i];
    }
    double result=biggest-smallest;
    return result;
}