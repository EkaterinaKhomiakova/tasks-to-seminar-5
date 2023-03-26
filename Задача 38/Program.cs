// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray (double[] array, double avg=0)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = Math.Round(new Random().NextDouble () *(50-10)+10); 
}

double ReleaseArray (double[] array, double avg)
{
    double max1= array[0];
    double min1= array[0];
for (int i = 0; i < array.Length; i++) 
	if (array[i] > max1)
        max1 = array[i];
for (int i = 0; i < array.Length; i++) 
    if (array[i] < min1)
        min1= array[i];
avg= max1 - min1; 
return avg;
}       

void PrintArray (double[] array)
{
	Console.WriteLine ($"[{string.Join (",",  array)}]");
}
Console.Clear();
Console.Write($"n =");
int n = Convert.ToInt32(Console.ReadLine()); 
double avg = 0;
double[] array = new double [n];

InputArray (array);
PrintArray (array);
Console. WriteLine(ReleaseArray(array, avg));