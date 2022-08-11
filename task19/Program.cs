// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число");
string a_text = Convert.ToString(Console.ReadLine());
if (a_text.Length == 5)
{
    if (a_text[0] == a_text[4])
    {
        if (a_text[1] == a_text[3])
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("число не пятизначное");
}