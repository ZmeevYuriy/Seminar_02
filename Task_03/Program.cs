// Задача № 15

Console.Write("Введи цифру дня нидели: ");
int a = Convert.ToInt32(Console.ReadLine());

void DayWeek (int a) 
{
    if (a == 6 || a == 7) 
{
    Console.WriteLine("День нидели выходной: да");
}
  else if (a < 1 || a > 7) 
{
    Console.WriteLine("Такого дня нидели не существует");
}
  else Console.WriteLine("День нидели не выходной: нет");
}

DayWeek(a);