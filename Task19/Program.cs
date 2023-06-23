 double result;

            void Print(string text)
            {
                Console.WriteLine(text);
            }

            int GetIntNumber()
            {
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }

            double CalcDistance(int x1, int y1, int z1, int x2, int y2, int z2)
            {
                result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
                return result;
            }

            Print("Insert one by one x1, y1, z1, x2, y2, z2");
            int x1 = GetIntNumber();
            int y1 = GetIntNumber();
            int z1 = GetIntNumber();
            int x2 = GetIntNumber();
            int y2 = GetIntNumber();
            int z2 = GetIntNumber();

            result = CalcDistance(x1, y1, z1, x2, y2, z2);
            Print($"Distance is {result}");




            Console.ReadKey();