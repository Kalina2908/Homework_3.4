/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
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

int GetSum (int number)
{
    int result=0;
    while (number>0)
    {
        result=result+number%10;
        number=number/10;
    }
    return result;
}

int number = GetNumber("Введите число:");
int res = GetSum(number);
Console.WriteLine(res);