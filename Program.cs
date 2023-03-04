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
int[] FastSortingArray(int[] sortArray, int left, int right)
{
	int i = left;
	int j = right;

	int pivot = sortArray[Random.Shared.Next(left, right)];

	while (i <= j)
	{
		while (sortArray[i] < pivot) i++;
		while (sortArray[j] > pivot) j--;
		Console.WriteLine($"Опорное значение = {pivot}.");
		if (i <= j)
		{
			Console.WriteLine($"Меняем местами = {sortArray[i]} и {sortArray[j]}");
			int temp = sortArray[i];
			sortArray[i] = sortArray[j];
			sortArray[j] = temp;
			i++;
			j--;
		}
		PrintArrayToConsole(sortArray);
		Console.WriteLine("<--- шаг сортировки");
	}
	if (i < right) FastSortingArray(sortArray, i, right);
	if (left < j) FastSortingArray(sortArray, left, j);

	return sortArray;
}

int size = GetRandomNumber(1, 50);
int[] oldArray = GetRandomArray(size);
Console.WriteLine("Изначальный массив:");
PrintArrayToConsole(oldArray);
Console.WriteLine();
int[] fastSortArray = FastSortingArray(oldArray, 0, oldArray.Length - 1);
Console.WriteLine("Отсортированный массив:");
PrintArrayToConsole(fastSortArray);