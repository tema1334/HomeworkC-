// DZ_01   
/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


Console.WriteLine("Введите 1 число:");
string OneNumberSrn = Console.ReadLine();
Console.WriteLine("Введите 2 число:");
string TwoNumberStr = Console.ReadLine();

int numberOne = Convert.ToInt32(OneNumberSrn);
int numberTwo = Convert.ToInt32(TwoNumberStr);

if (numberOne > numberTwo)
{
    Console.WriteLine($" Первое число {numberOne} больше Второго числа  {numberTwo} ");
}
else
{
    Console.WriteLine($" Второе число {numberTwo} больше первого числа  {numberOne} ");
}
    