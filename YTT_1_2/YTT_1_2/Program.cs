/* УП Практическая работа 2.1
Задание 2. Дан целочисленный массив (candidates) и цель (target),
найдите все уникальные комбинации чисел, сумма которых равна цели.
Каждое число может быть использовано только один раз в комбинации.
Набор решений не должен содержать повторяющихся комбинаций. */

namespace YTT_1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] candidates = { 10, 1, 2, 7, 6, 1, 5 }; 
            int target = 8;
            Array.Sort(candidates);
            List<List<int>> combinations = new List<List<int>>();
            function(combinations, new List<int>(), 0, candidates, target);
            
            foreach (var n in combinations)
            {
                Console.Write("[");
                for (int i = 0; i < n.Count; i++)
                {
                    if (i == n.Count - 1)
                    {
                        Console.Write($"{n[i]}]");
                    }
                    else
                    {
                        Console.Write($"{n[i]}, ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void function(List<List<int>> combinations, List<int> arrayTemp, int start, int[] candidates, int target)
        {
            if (target < 0)
            {
                return;
            }
            else if (target == 0)
            {
                combinations.Add(new List<int>(arrayTemp));
            }
            else
            {
                for (int i = start; i < candidates.Length; i++)
                {
                    if (i > start && candidates[i] == candidates[i - 1])
                    {
                        continue;
                    }
                    arrayTemp.Add(candidates[i]);
                    function(combinations, new List<int>(arrayTemp), i + 1, candidates, target - candidates[i]);
                    arrayTemp.RemoveAt(arrayTemp.Count - 1);
                }
            }
        }
    }
}