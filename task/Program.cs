// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr1 = new int [n];
for(int i = 0; i < arr1.Length; i++) 
{   Console.Write("Введите элемент массива: ");
    arr1[i] = Convert.ToInt32(Console.ReadLine());   
}
Console.Write("Массив: [" + string.Join(", ", arr1) + "]");
int res = 0;
for (int i = 0; i < arr1.Length; i++)
{  
    if (arr1[i] > 0)
       res = res + 1;      
}
Console.WriteLine();
Console.Write("Количество положительных элементов в массиве :" + res);







