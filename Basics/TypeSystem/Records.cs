namespace TypeSystem
{
    public class Records()
    {
        public record Person(string Name, int Age);

        public static void ShowRecords()
        {
            Person p1 = new("shahil", 22);

            Console.Write(p1 + " ");
        }
    }
}
