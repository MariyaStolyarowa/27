//Задача 27: Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
int A, Sum=0;
Console.Write("Введитe число: ");
A=Convert.ToInt32(Console.ReadLine());
while (A>=10)
    {Sum=Sum+A%10; A=A/10;}
Console.WriteLine(Sum+A);