void Print(string text)
    {
            Console.WriteLine(text);
    }

        Print("Add number to check");
       int num = Convert.ToInt32(Console.ReadLine());

void getCube(int num)
    {
        for (int i=1; i<=num; i++)
        {
            Console.Write($"{Math.Pow(i,3)}, ");
        }
    }
Print($"{num}");
getCube (num);
    