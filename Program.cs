namespace FindSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, 5, 12, 10, 9, 21, 7, 23, 19, 11, 3, 16 };
            Array.ForEach(mas, x => Console.Write(x + " "));
            Console.WriteLine("\nEnter required sum");
            bool num = Int32.TryParse(Console.ReadLine(), out int required);
            if (num)
            {
                Dictionary<int, int> dict = new Dictionary<int, int>();
                for( int i = 0;  i < mas.Length; i++)
                {
                    for( int j = i+1; j < mas.Length; j++)
                    {
                        if ((mas[i] + mas[j]) == required) dict.Add(mas[i], mas[j]);
                    }
                }
                Console.WriteLine("Found numbers:");
                foreach(int key in dict.Keys)
                {
                    dict.TryGetValue(key, out int value);
                    Console.WriteLine($"{key} + {value}");
                }
            }
        }
    }
}
