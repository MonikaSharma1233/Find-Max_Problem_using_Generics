namespace FindMaximumNumber
{
    class Program
    {
        public static void Main(string[] args)
        {

            int output = FindMax.Find_max_int(45, 78, 199);
            Console.WriteLine(output);
            double output1 = FindMax.Find_max_float(4.98, 18.9, 9.5);
            Console.WriteLine(output1);
        }
    }
}

