namespace AsyncProgramming
{
    public class ExceptionHandeling
    {
        static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        public static void ShowExceptionHandeling(int n1, int n2)
        {
            try
            {
                int result = Divide(n1, n2);

                Console.WriteLine($"Result is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0");
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception occured {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }
    }
}
