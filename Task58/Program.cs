// Задача № 58 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы: 2 4 | 3 4
//                           3 2 | 3 3
// Результирующая матрица будет: 18 20
//                               15 18


Console.WriteLine("Первый массив");
int[,] firstArray = CreateArray(2, 2);
PrintArray(firstArray);
Console.WriteLine("Второй массив");
int[,] secondArray = CreateArray(2, 2);
PrintArray(secondArray);
Console.WriteLine("Перемноженный массив");
PrintArray(ResultArray(firstArray, secondArray));

int[,] CreateArray(int m, int n)
{
    int[,] result = new int[m, n];
    var random = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = random.Next(1, 10);
    return result;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] ResultArray(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < secondArray.GetLength(1); k++)
                result[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }

    return result;
}






// Console.Write("Введите количество строк 1ого  массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 1ого и строк 2ого массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 2ого массива: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int[,] FistArray = new int[m, n];
// int[,] SecondArray = new int[n, a];

// FillArray(FistArray);
// Console.WriteLine();
// FillArray1(SecondArray);

// // int[,] MultiplyArray = new int[FistArray.GetLength(0), SecondArray.GetLength(1)];

// // // Console.Write("Введите количество строк 2ого  массива: ");
// // // int a = Convert.ToInt32(Console.ReadLine());
// // // // Console.Write("Введите количество столбцов 2ого массива: ");
// // // // int b = Convert.ToInt32(Console.ReadLine());
// // // int[,] SecondArray = new int[n, n];

// // MultipliedArray(FistArray, SecondArray, MultiplyArray);

// void FillArray(int[,] FistArray)
// {
//     for (int i = 0; i < FistArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < FistArray.GetLength(1); j++)
//             FistArray[i, j] = Convert.ToInt32(new Random().Next(0, 10));
//     }
//     for (int i = 0; i < FistArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < FistArray.GetLength(1); j++)
//             Console.Write(FistArray[i, j] + "\t  ");
//         Console.WriteLine();
//     }
// }

// void FillArray1(int[,] SecondArray)
// {
//     for (int i = 0; i < SecondArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < SecondArray.GetLength(1); j++)
//             SecondArray[i, j] = Convert.ToInt32(new Random().Next(0, 10));
//     }
//     for (int i = 0; i < SecondArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < SecondArray.GetLength(1); j++)
//             Console.Write(SecondArray[i, j] + "\t  ");
//         Console.WriteLine();
//     }
// }

// // void MultipliedArray(int[,] FistArray, int[,] SecondArray, int[,] MultiplyArray)
// // {
// //     for (int i = 0; i < FistArray.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < FistArray.GetLength(1); j++)
// //         {
// //             int sum = 0;
// //             for (int k = 0; k < FistArray.GetLength(1); k++)
// //             {
// //                 sum += FistArray[m,n] * SecondArray[n, a];
// //                 // sum = (FistArray[m, n] * SecondArray[a, b]);
// //             }
// //             MultiplyArray[i, j] = sum;
// //         }
// //     }
// //   for (int i = 0; i < FistArray.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < FistArray.GetLength(1); j++)
// //             Console.Write(FistArray[i, j] + "\t  ");
// //         Console.WriteLine();
// //     }
// // }



