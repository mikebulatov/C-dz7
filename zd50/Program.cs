
Console.WriteLine("ЗЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");


Console.Write("Введите первую размерность массива:");
int i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую размерность массива:");
int j=Convert.ToInt32(Console.ReadLine());

int [,] matrix=new int [i,j];

Console.WriteLine("Сформированный массив:");
for(i=0; i<matrix.GetLength(0); i++)
{
    for(j=0; j<matrix.GetLength(1); j++)
    {
    matrix[i,j]= new Random().Next(0,10);
     Console.Write("{0:D2} ", matrix[i,j]);
    
    }
    Console.WriteLine();
}
Console.Write("Введите номер строки элемента:");
i=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки элемента:");
j=Convert.ToInt32(Console.ReadLine());
if(i>0 & i<=matrix.GetLength(0) & j>0 & j<=matrix.GetLength(1))
{
  Console.WriteLine("Значение элемента позицией {0},{1}: {2:D2}",i,j,matrix[i-1,j-1]);
}
else{Console.WriteLine($"Елемента с позицией {i};{j} нет");}