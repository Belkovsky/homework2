/*

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int findnumber(){

    int random = new Random().Next(100,1000);
    Console.WriteLine ("случайное число =" + random);
    int firstnumber = random / 10;//первое число
    int thirdnumber = random%10;// третье число, но небязательно для выполнения условия задачи
    int secondnumber = firstnumber%10;// второе число
    int result = secondnumber;
   
    return result;
}

int result = findnumber();
Console.WriteLine("результат =" + result);

*/

/*

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число: ");
string check = Console.ReadLine();
long num = Convert.ToInt64(check);
void thirddigit(long num){
  
    if (check.Length < 3)
    {
        Console.WriteLine ("третьей цифры нет");
    }
    else if (check.Length == 3)
    {
       
        long result = num%10;
        Console.WriteLine("третье число " + result);
    }   
    else if (check.Length > 3)
    {
        //Console.WriteLine (check.Length);
        var num2 = Math.Truncate(num / Math.Pow(10,(check.Length - 3)));
        
        long num1 = Convert.ToInt64 (num2);
        Console.WriteLine (num1%10);
    }
    }
    
thirddigit(num);
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
void weeknumber (long num)
{
    if (num > 0 & num <= 5)
    {
Console.WriteLine ("Сегодня рабочий день :(");
    }
if (num > 5 & num <= 7)
    {
Console.WriteLine ("Сегодня выходной!");
    }
    if (num == 0 || num > 7)
    {
Console.WriteLine ("Такого дня недели еще не придумали");
}
}
Console.Write("Введите номер соответствующий дню недели: " );
long day = Convert.ToInt64(Console.ReadLine());

weeknumber(day);
