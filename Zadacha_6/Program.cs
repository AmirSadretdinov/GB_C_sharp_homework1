﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
int a;
System.Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
if (a%2==0){
    System.Console.WriteLine("Число " + a + " четное");
}
if (!(a%2==0)){
    System.Console.WriteLine("Число " + a + " нечетное");
}

