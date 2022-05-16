// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите значение m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение n: ");
// int n = Convert.ToInt32(Console.ReadLine());


// double[,] array = new double[m, n];
// double min = -10.0,  max = 10.0;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = Math.Round((new Random().NextDouble() * (max - min) + min), 2);
//     }
// }


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }







// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = new Random().Next(1, 11);
//     }
// }


// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Введите позицию элемента в двумерном массиве: ");

// string position = Console.ReadLine();
// int position0 = Convert.ToInt32(Convert.ToString(position[0]));
// int position1 = Convert.ToInt32(Convert.ToString(position[1]));
// //Console.WriteLine(position1);


//  for (int i = 1; i <= m; i++)
//  {
//      for (int j = 1; j <= n; j++)
//     {
//         if (position0 == i && position1 == j)
//             Console.WriteLine(array[i-1, j-1]);
//      }
//  }

//  if (position0 > m || position1 > n)
//  {
//      Console.WriteLine("Такого числа в массиве нет!");
//  }


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


//  Console.Write("Введите m: ");
//  int m = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите n: ");
//  int n = Convert.ToInt32(Console.ReadLine());

//  int[,] array = new int[m, n];

//  for (int i = 0; i < m; i++)
//  {
//      for (int j = 0; j < n; j++)
//      {
//          array[i, j] = new Random().Next(1, 11);
//      }
//  }


//  for (int i = 0; i < m; i++)
//  {
//      for (int j = 0; j < n; j++)
//      {
//          Console.Write(array[i, j] + " ");
//      }
//      Console.WriteLine();
//  }

//  int midAref = 0;
 
//  for (int i = 0; i < m; i++)
//  {
//     for (int j = 0; j < n; j++)
//     {
        
//     }
//  }







Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 11);
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
} 

double result = 0;

for (int j = 0; j < n; j++)
{
    result = SredAref(j);
    Console.WriteLine(result);
}



double SredAref(int column)
{
    double sredArefme = 0;
    double x = 0;
    for (int i = 0; i < m; i++)
{
    sredArefme += array[i, column];
}
x = sredArefme / m;
return x;
}