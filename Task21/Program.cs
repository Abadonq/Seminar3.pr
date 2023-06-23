/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void Print(string text)
    {
            Console.WriteLine(text);
    }
int GetNum()
    {
        Print("Add a 5 digit number to check");
        int num = Convert.ToInt32(Console.ReadLine);
        return num;
    }
int CheckNum(int num, int num1, int num2, int num3, int num4, int num5)
    {
        num1 = num/10000;
        num2 = num/1000&10;
        num3 = num/100%10;
        num4 = num/10%10;
        num5 = num%10;
        return  num;
    }
void logic(int num1, int num2, int num3, int num4, int num5)
    {
        if(num1 == num5 ||  num2 == num3 )
        {
            Print("yes");
        }
        else
        {
            Print("no");
        }
    }

    

    