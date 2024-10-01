namespace LinQ_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Ques1");
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var nQuery = from tmp in n1
                         where (tmp % 2) == 0
                         select tmp;
            foreach (var n in nQuery) 
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            //2
            Console.WriteLine("Ques2");
            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var nQuery2 = from tmp in n1
                         where tmp > 0
                         where tmp < 12
                         select tmp;
            foreach (var n in nQuery2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            //3
            Console.WriteLine("Ques3");
            List<string> animals = new List<string> { "zebra", "elephant", "cat", "dog", "rhino", "bat"};
            var selectedAnimals = animals.Where(s => s.Length >= 5).Select(x => x.ToUpper());
            foreach (var n in selectedAnimals)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            //4
            Console.WriteLine("Ques4");
            List<int> numbers = new List<int> { 6, 0, 999, 11, 443, 6, 1, 24, 54 };
            var top5 = numbers.OrderByDescending(x => x).Take(5);
            foreach (var n in top5)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");

            //5
            Console.WriteLine("Ques5");

        }
    }
}