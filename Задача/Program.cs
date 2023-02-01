string[] ArrayOne = new string[4] {"Hello","2","world",":)-"}; // созадли исходный массив
string[] ArrayTwo = new string[ArrayOne.Length]; // создали масив для вывода с длиной первого массива
int count = 0; // создали переменную для записи

void CopuCut(string[] ArrayOne, string[] ArrayTwo)
{
    int count= 0;
    for (int i = 0; i < ArrayOne.Length; i++) // проходим по 1 массиву
    {
        if(ArrayOne[i].Length<=3) // если длина первого значения массива меньше или ровна трем символам, то записываем в масссив для вывода
        {
            ArrayTwo[count]=ArrayOne[i];
            count++; // Запись в массив ArrayTwo
        }
    }
}

void Print(string[] Array)
{
    for (int i = 0; i < array.length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}
