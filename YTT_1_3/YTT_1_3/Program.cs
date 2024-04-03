/* УП Практическая работа 2.1
Задание 3. Дан целочисленный массив nums, верните true, если какое-либо значение
встречается в массиве по крайней мере дважды, иначе верните false. */

namespace YTT_1_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 1 };
            bool output = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        output = true;
                    }
                }
            }

            if (output)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}