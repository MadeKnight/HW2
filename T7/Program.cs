Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 5)
{
    Console.Write("Рабочий день");
}
else if (number >= 6 && number <= 7)
{
    Console.Write("Выходной день");
}
else Console.Write("Не существует такого дня недели");