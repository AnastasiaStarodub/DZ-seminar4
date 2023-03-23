// Программа, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int Len(int A)
{
    int i = 0;
    while (A > 0)
    {
        A = (A / 10);
        i = i + 1;
    }
    return i;
}
int len = Len(A);

int Sum(int A, int len)
{
    int result = 0;
    for (int i = 1; i <= len; i++)
    {
        result = result + (A % 10);
        A = A / 10;

    }
    return result;
}

Console.WriteLine($"Сумма цифр в числе {A} равна {Sum(A, len)}");
