// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GenerateArray(int count){
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1000);
    }
    return array;
}

int size = 8;
int[] resultArray = GenerateArray(8);
Console.WriteLine($"[{String.Join(", ",  resultArray)}]");


