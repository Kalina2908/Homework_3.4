/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result>0)
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


void GetArray(int numberLenght, int a, int b) 
{
    int [] array = new int [numberLenght];
    Random number = new Random ();
    int i=0;
    for (i=0; i<array.Length; i++)
    {
        array[i]=number.Next (a, b);
        Console.Write((array[i])+ " ");
    }
}

int numberLenght = GetNumber("Введите размер массива:"); // пользователь сам задает размер массива
int a = GetNumber ("Введите начальное значание массива: "); // пользователь сам выбирает минимальное значение в массиве
int b = GetNumber ("Введите конечное значание массива: "); // и самостоятельно выбирает макисмальное значение в массиве
GetArray (numberLenght, a, b); // вывод на экран рандомного массива с параметрами, обозначенными пользователем (размер, мин и макс значение в массиве)

