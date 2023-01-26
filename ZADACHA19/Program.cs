// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine ("Введите число: ");
String number = Console.ReadLine();

System.Console.WriteLine(number);


char[] numberReverse = number.ToCharArray ();
Array.Reverse (numberReverse);
String numb = new string(numberReverse);

System.Console.WriteLine(numb);

if(number == numb)
{ 
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}
