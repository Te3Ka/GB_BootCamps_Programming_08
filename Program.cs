//Печать массива в консоль
void PrintArrayToConsole(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
    	if (i == printArray.Length - 1)
        	Console.Write($"{printArray[i]}");
        else
        	Console.Write($"{printArray[i]}, ");
    }
    Console.Write("]");
}

//Получение случайного числа
int GetRandomNumber(int min, int max)
{
	Random rnd = new Random();
	return rnd.Next(min, max + 1);
}

//Создание случайного массива
int[] GetRandomArray(int length)
{
	int[] randomArray = new int[length];
	for (int i = 0; i < length; i++)
	{
		randomArray[i] = GetRandomNumber(0, 100);
	}
	return randomArray;
}

//Быстрая сортировка


int size = GetRandomNumber(1, 50);
int[] oldArray = GetRandomArray(size);
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(oldArray);
Console.WriteLine();
int[] fastSortArray = FastSortArray(oldArray);
Console.WriteLine("Отсортированный массив:");
PrintArrayToConsole(sortBubleArray);