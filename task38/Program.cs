/*Задайте массив вещественных(тип double) чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

Console.Write("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
double [] array = new double [N];
for(int i = 0; i < N; i++)
{
    Console.Write($"Введите {i+1}-й элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
string arr = string.Join(" ", array);
Console.Write("[");
Console.Write(arr);
Console.Write("]");
Console.WriteLine();
double max = double.Parse(array[0].ToString());
double min = double.Parse(array[0].ToString());
for (int i = 0; i < array.Length; i++)
{
    if (double.Parse(array[i].ToString()) > max)
        {
            max = double.Parse(array[i].ToString());
        }
    else if (double.Parse(array[i].ToString()) < min)
        {
            min = double.Parse(array[i].ToString());
        }
}
Console.WriteLine($"max = {Math.Round(max,3)}");
Console.WriteLine($"min = {Math.Round(min,3)}");
double otvet = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {Math.Round(otvet,3)}");