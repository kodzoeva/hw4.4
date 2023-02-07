// : Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// Домашнее задание урок 4

// Функция входа
int ImputValue(string msg)
{
    System.Console.Write(msg);
    string value = Console.ReadLine(); 
    return Convert.ToInt32(value); 
}

// функция расчетов
int Summ(int number)
{
    int sum = 0;
    while (number != 0)
    {
        int count = number % 10;
        sum += count;
        number/= 10;
    }
    return sum;
}

// Функция вывода

int number =  ImputValue ("Введите число: ");
int result = Summ(number);
System.Console.WriteLine("Сумма чисел в нем: " + (result));