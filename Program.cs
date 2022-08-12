/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

int num1 = new Random().Next(1, 11);
int num2 = new Random().Next(1, 11);
int max = 0;
int min = 0;
if (num1 > num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}
Console.WriteLine($"Максимальное число {max}, минимальное число {min}");


/*----------------------------------------------------*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

int number1 = new Random().Next(1, 101);
int number2 = new Random().Next(1, 101);
int number3 = new Random().Next(1, 101);
int maximum = number1;

if (number2 > maximum) maximum = number2;
if (number3 > maximum) maximum = number3;

Console.WriteLine(maximum);

/*----------------------------------------------------*/

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

double num_d = new Random().Next(-10, 11);

if (num_d % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
Console.WriteLine(num_d);

/*----------------------------------------------------*/

/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/

int number = new Random().Next(1, 11);
int i = 0;
//Console.WriteLine(number);
while (i <= number)
{
    if (i % 2 == 0 && i != 0) Console.WriteLine(i);
    i++;
};

/*----------------------------------------------------*/
