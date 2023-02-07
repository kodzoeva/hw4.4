// Напишите цикл, который принимает на
//  вход два числа (A и B) и возводит число A в 
//  натуральную степень B. Не использовать Math.Pow
//  ДОМАШНЕЕ ЗАДАНИЕ 4


int ImputValue(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
  return Convert.ToInt32(value);
}
bool ChehkNumber (int b)
{
    if (b < 0)
    {
    System.Console.WriteLine("Показатель не должен быть отрицательным");
    return false;
    }
    return true;
}

long MyPow(int a, int b)
{
int degree = 1;
int result = 1;
while (degree <= Math.Abs(b))
{
    result *=a;
    degree ++;
}
return result;
}

int a = ImputValue("Введите основание числа");
int b = ImputValue("Введите показатель числа");

if (ChehkNumber (b))
{
    long result = MyPow(a,b);
    System.Console.WriteLine($"Число {a}  в натуральной степени  {b} = {result}");

}

