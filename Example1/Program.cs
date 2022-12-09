/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите число");
string number = Console.ReadLine();
bool isPalindrom = true;
for (int i = 0; i < number.Length/2; i++)
{
    if (number[i] != number[number.Length - 1 - i]) {
        isPalindrom = false;
        break;
    }
}

if (isPalindrom) {
    Console.WriteLine("палиндром");
} else {
    Console.WriteLine("не палиндром");
}

