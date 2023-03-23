// Цикл, который принимает на вход два числа (A и B) и возводит
// число A в натуральную степень B.

int Degree(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
    result = result * A;
    }
    return result;
}
Console.WriteLine("Введите число 1: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {A} в степени {B} равно {Degree(A, B)}");



