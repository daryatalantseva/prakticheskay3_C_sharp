// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
void palindrom(int n)
{
    int a,b,c,d;
    a = n / 10000;
    b = n / 1000 % 10;
    c = n % 100 / 10;
    d = n % 10;
    if (a == d & b == c)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не является палиндромом");
    }
    return;
}

Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 9999 & n < 10000 )
{
    Console.WriteLine("Данное число не является пятизначным");

}
else
{
   palindrom(n);
  
    
}
