namespace TypeSystem
{
    public class Variables
    {
        public static void ShowVariables()
        {
            int number = 10;

            string message = "Hello, Variables!";

            Console.WriteLine($"Number: {number}, Message: {message}");

            var list = new List<int> { 1, 2, 3, 3, 4 };

            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
        }
    }
}
