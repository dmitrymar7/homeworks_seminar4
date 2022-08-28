// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Power(int num, int degree){
    int result = num;
    for (int i = 1; i < degree; i++){
        result *= num;
    }
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Power(a, b);
Console.WriteLine($"число {a} в степени {b} = {result}");