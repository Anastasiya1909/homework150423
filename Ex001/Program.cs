//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да 
// 12821 -> да

bool PaliTest(int num)
{
bool res = false;
        int d1 = num / 10000;
        int d2 = (num / 1000) % 10;
        int d3 = (num / 10) % 10;
        int d4 = num % 10;
        res = ((d1 == d4) && (d2 == d3)) ? true : false;
    return res;
}
Console.WriteLine ("Введите пятизначное число:");
int FiveNumDig = int.Parse (Console.ReadLine());

bool answer = PaliTest(FiveNumDig);

if(answer == true) 
{
    Console.WriteLine ("Число: " + FiveNumDig + " является палиндромом :))");
}
else if(answer == false) 
{
     Console.WriteLine ("Число: " + FiveNumDig + " не является палиндромом :((");
}