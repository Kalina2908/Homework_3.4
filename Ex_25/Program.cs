/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }
    }
    return result;
}

int GetResult(int A, int B)
{
int result = 1;
for (int i=0; i<B; i++)
{
    result=result*A;
}
return result;
}

int A = GetNumber("Введите число: ");
int B = GetNumber("Введите число: ");
int res=GetResult(A, B);
Console.WriteLine(res);