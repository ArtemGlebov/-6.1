using System;

namespace Task6._1
{                   /*  Резул.раб.програм.
                        1) Одном.мас. от 3до8 слов(это массивы), в кaждом элементе(массиве) от 5 до 10 букв рандомных.
                        Сначало рандомные слова, потом ран.буквы.
                        2) Посчитать общее колличество согласных букв(после выпоненного 1))
                        3) Использовать только латинс.буквы*/
    class Program
    {
        static void Main(string[] args)
        {

            Random ran = new Random();
            int num1 = ran.Next(3, 8);
            int num2 = ran.Next(5, 10);
            string[,] line = new string[num1, num2];

            

            for (int i = 0; i < line.GetLength(0); i++) //заполняю строки
            {
                for (int j = 0; j < line.GetLength(1); j++)
                {
                    line[i, j] = ((char)ran.Next('a', 'z')).ToString();
                    Console.Write("  "+line[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
