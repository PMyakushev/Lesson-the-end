string[] ArrayOne = new string[4] {"Hello","2","world",":)-"}; // созадли исходный массив
string[] ArrayTwo = new string[ArrayOne.Length]; // создали масив для вывода с длиной первого массива

void CopyCut(string[] ArrayOne, string[] ArrayTwo)
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

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} "); // Выводим массив через фукнцию PrintArray
    }
    Console.WriteLine();
}
CopyCut(ArrayOne,ArrayTwo);
PrintArray(ArrayOne);
PrintArray(ArrayTwo);

