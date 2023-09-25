int maxNum = 1000;
int a = 10;
int b = 100;

string msg = "нет 3го числа";
string wlc = "Введите трехначное число: ";

CalcNum(); //Потренировался в написании методов

#region Methods

bool CheckMaxNum(int num)
{
   return (num > maxNum);
}

int DecreaseNum(int num)
{
   return num /= a;
}

void CalcNum()
{
   Console.WriteLine(wlc);
   int number = Convert.ToInt32(Console.ReadLine());
   
   while (CheckMaxNum(number))
   {
      number = DecreaseNum(number);
   }

   FoundThrdDigit(number);
}

void FoundThrdDigit(int num)
{
   if (num <= b)
   {
      Console.WriteLine(msg);
   }
   else
   {
      int result = num%a;
      Console.WriteLine(result);
   }
}

#endregion