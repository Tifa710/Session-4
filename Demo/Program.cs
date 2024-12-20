namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++) 
            {
                Console.Write(i);
                if (i < number) {
                    Console.Write("\n"); 
                } 
            }
            #endregion
        }
    }
}
