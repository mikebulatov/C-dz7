

Console.WriteLine("ЗЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");



Console.Write("Введите первую размерность массива:");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int columns=Convert.ToInt32(Console.ReadLine());

int [,] matrix=new int [rows,columns];

Console.WriteLine("Сформированный массив:");
for(int i=0; i<matrix.GetLength(0); i++)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
    matrix[i,j]= new Random().Next(0,10);
     Console.Write("{0:D2} ", matrix[i,j]);
    
    }
    Console.WriteLine();
}
Console.Write("Введите номер колонки элемента:");
int rows=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int columns=Convert.ToInt32(Console.ReadLine());
