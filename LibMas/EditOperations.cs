using System;
using System.IO;

namespace LibMas
{
    public class EditOperations
    {
        public static void FillMas(int numbersCount, out int[] generatedArray)
        {
            generatedArray = new int[numbersCount];
            Random randomNumber = new Random();
            for (int i = 0; i < numbersCount; i++)
            {
                generatedArray[i] = randomNumber.Next(-50, 50);
            }
        }
        public static void SaveMatrix( int[] matrix)
        {
            using (StreamWriter save = new StreamWriter(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt")))
            {
                save.WriteLine(matrix.GetLength(0));
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    save.WriteLine(matrix[i]);
                }
            }
        }
        public static void OpenArray( out int[] savedArray)
        {
            using (StreamReader open = new StreamReader(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "file.txt")))
            {
                int arrayLenght = Convert.ToInt32(open.ReadLine());
                savedArray = new int[arrayLenght];
                for (int i = 0; i < savedArray.GetLength(0); i++)
                {
                    savedArray[i] = Convert.ToInt32(open.ReadLine());
                }
            }
        }
    }
}
