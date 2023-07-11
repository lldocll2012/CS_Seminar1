void Task0()
{
int numb = 5;

int result = numb * numb;

Console.WriteLine(result);
}


void Task1()
{
Console.WriteLine("Введите первое число");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");

int b = Convert.ToInt32(Console.ReadLine());

 if (a == b*b)
 {
    Console.WriteLine("Первая переменная является квадратом второй");
 }
 else
 {
    Console.WriteLine("Первая переменная НЕ является квадратом второй");
 }
}









void Task2()
{
  Console.WriteLine("Введите число");    
 int day = Convert.ToInt32(Console.ReadLine());
 if (day == 1)
 {
    Console.WriteLine("понедельник");
 }
 else if (day == 2)
 {
    Console.WriteLine("вторник");
 }
 else if (day == 3)
 {
    Console.WriteLine("среда");
 }
 else if (day == 4)
 {
    Console.WriteLine("четверг");
 }
 else if (day == 5)
 {
    Console.WriteLine("пятница");
 }
 else if (day == 6)
 {
    Console.WriteLine("суббота");
 }
 else if (day == 7)
 {
    Console.WriteLine("воскресенье");
 }
}


void Task3()
{

 int Power(int number)
 {
   return number * number;
 }

 Console.WriteLine("Введите число");
 int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(num));
}


void Task4()
{
  Console.WriteLine("Введите число");
  int num = Convert.ToInt32(Console.ReadLine());
  num = Math.Abs(num);

  int count = -num;

  while (count <= num)
  {
    Console.Write(count + " ");
    count++;
  }
}

Task4();