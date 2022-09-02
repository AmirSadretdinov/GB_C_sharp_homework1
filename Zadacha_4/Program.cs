// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int a, b, c, max;

System.Console.WriteLine("Введите число а");
a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число b");
b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число c");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (max>b){
    max=max;
    if (max>c){
        max=max;
    }
}
if (max<b){
    max=b;
    if (max>c){
        max=max;
    }
}
if (max<c){
    max=c;
}
System.Console.WriteLine(max);