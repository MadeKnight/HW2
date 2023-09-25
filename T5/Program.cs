Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = number%100;
int result = secondDigit/10;
Console.WriteLine(result);