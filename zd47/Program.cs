

Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами..");



Console.Write("Введите первую размерность массива:");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int columns=Convert.ToInt32(Console.ReadLine());

float [,] matrix=new float [rows,columns];

Console.WriteLine("Сформированный массив:");
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
    matrix[i,j]= new Random().Next(0,10);
    matrix[i,j]= matrix[i,j] / new Random().Next(1,10);
    Console.Write("{0:F1} ", matrix[i,j]);
    
    }
    Console.WriteLine();
}

