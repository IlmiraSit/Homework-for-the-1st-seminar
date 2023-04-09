//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
Console.Write("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum % 2 == 0 )
{
    Console.Write($"Число {userNum} четное. ");
}
else
{
    Console.Write($"Число {userNum} нечетное. ");
}
