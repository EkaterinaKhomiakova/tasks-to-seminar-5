// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void InputArray (int[] array)
{
	for (int i = 0;  i < array.Length; i++)
		array[i] = new Random().Next (100, 1000); 
}

int RealeseArray (int[] array)
{
	int count = 0;
for (int i = 0; i < array.Length; i++) 
	if (array[i] >= 0 && array [i]%2 == 0)
		count ++;
return count;
}

void PrintArray (int[] array)
{
	Console.WriteLine ($"[{string.Join (",",  array)}]");
}
Console.Clear();
Console.Write($"n =");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
PrintArray (array);
Console. WriteLine(RealeseArray(array));
