// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.Write("Введите количество элементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] arr1 = new int [n];
// for(int i = 0; i < arr1.Length; i++) 
// {   Console.Write($"Введите элемент массива {i}: ");
//     arr1[i] = Convert.ToInt32(Console.ReadLine());   
// }
// Console.Write("Массив: [" + string.Join(", ", arr1) + "]");
// int res = 0;
// for (int i = 0; i < arr1.Length; i++)
// {  
//     if (arr1[i] > 0)
//        res = res + 1;      
// }
// Console.WriteLine();
// Console.Write("Количество положительных элементов в массиве :" + res);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.WriteLine("Введите координаты первой прямой: ");
// double b1 = Convert.ToInt32(Console.ReadLine()), k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй прямой: ");
// double b2 = Convert.ToInt32(Console.ReadLine()), k2 = Convert.ToInt32(Console.ReadLine());
// double x = (b2 - b1)/(k1 - k2);
// double y = (k1 * x) + b1;
// Console.WriteLine($"Координаты точки: {x} , {y}");

// доп 1 (не готов)
// Console.WriteLine("Введите количество строк в матрице:");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов в матрице:");
// int column = Convert.ToInt32(Console.ReadLine());
// void PrintArray(int[,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         Console.Write($"{matr[i, j]}    ");
//     }
//     Console.WriteLine();
// }  
// }

// void FillArray (int [,] matr)
// {
//    for(int i =0; i < matr.GetLength(0); i++)  
//   for (int j = 0; j < matr.GetLength(1); j++)
//   {
//   matr[i,j] = new Random().Next (1,10);
//   }
// }

// void Arr (int [,] array)
// {
//     int n = array.GetLength(0);
//     int m = array.GetLength(1);
// for(int i = 0; i < n/2; i++)
// {
//     for(int j = 0; j < m; j++)
//     {
//        int temp = array[n - 1-i,j];
//         array[n - 1-i,j] = array[i,j];
//         array[i,j] = temp;
        
//         Console.Write($"{array[i,j]}    ");
//     }
//     Console.WriteLine();
    
// }
// for(int i = 0; i < n - i; i++)
// {
//      for(int j = 0; j < m; j++)
//      {   
//          int temp = array[i,j];
//          array[i,j] = array[n - 1 - i,j];
//          array[n - 1,j] = temp;
        
//          Console.Write($"{array[n-1,j]}    ");
//     }
//      Console.WriteLine();
// }
// }
// int [,] array = new int[line, column];
// Console.WriteLine("_______");

// FillArray(array);
// PrintArray(array);
// Console.WriteLine("_______");
// Arr(array);




