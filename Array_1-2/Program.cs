/*
Написать программу которая из имеющегося массива строк формирует массив из строк, 
длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

int[] Array1 = { 10, 13, 42, 69, 113, 25 };
int n1 = Array1.Length;
int index1 = 0;

System.Console.WriteLine("This is the first array");
while (index1 < n1)
{
    System.Console.Write($"{Array1[index1]} ");
    index1++;
}

System.Console.WriteLine();

int index2 = 2;
Random rand = new Random();
int index = rand.Next(Array1.Length);

System.Console.WriteLine("This is the second array");
while (index <= index2)
{
    Console.Write($"{Array1[index]} ");
    index++;
}
