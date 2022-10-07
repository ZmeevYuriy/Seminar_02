// Задача № 13

Console.WriteLine("Ведите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);

if (stringNumber.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
}

else
{
    Console.WriteLine("Третья цифра числа отсутствует");
}