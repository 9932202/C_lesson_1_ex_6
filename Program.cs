// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число:");
int namber = int.Parse(Console.ReadLine()!);

if(namber % 2 == 0){
    Console.WriteLine("ДА. Число четное");
}
else{
    Console.WriteLine("НЕТ. Число не четное");
}
