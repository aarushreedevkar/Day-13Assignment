namespace GenericsPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] Output = { 11, 22, 50, 60, 90 };
            Generic<int> genericInt = new Generic<int>(Output);//create object using int data type
            genericInt.PrintValue();
            Console.WriteLine();

            double[] Output1 = { 11.2, 22.5, 50.45, 55.92 };
            Generic<double> genericdouble = new Generic<double>(Output1);
            genericdouble.PrintValue();
            Console.WriteLine(
                );
            //String array
            string[] stringArray = { "111", "222", "333", "55", "999" };
            Generic<string> genericString = new Generic<string>(stringArray);
            genericString.PrintValue();
            Console.Read();






        }
    }
}
