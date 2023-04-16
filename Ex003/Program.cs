// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N. 
//3 -> 1, 4, 9.
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("Введите число:");
double num = double.Parse (Console.ReadLine());

for (int i = 0; i <= num; i++)
{
      Console.Write($" {Math.Pow(i, 3)}, ");
}