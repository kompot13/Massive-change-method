using System;

namespace Massive_change_method
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrray_1 = { 34, 6, -3, 88 };

            int valindex = 2;

            ChngArr(ref arrray_1, valindex);

            Console.WriteLine(arrray_1[2]);




        }
        static void ChngArr(ref int[] array_1, int valindex)
        {
            int[] array_2 = new int[valindex];//создали промежуточный массив

            if (valindex > array_1.Length) //увеличить массив
            {
                for (int i = 0; i < array_1.Length; i++)
                {
                    array_2[i] = array_1[i];
                }
                array_1 = array_2;
            }
            else if (valindex < array_1.Length) //уменьшить массив
            {
                for (int i = 0; i < array_2.Length; i++)
                {
                    array_2[i] = array_1[i];
                }
                array_1 = array_2;
            }
        }
    }
}
