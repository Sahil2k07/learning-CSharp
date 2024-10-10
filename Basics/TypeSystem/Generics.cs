namespace TypeSystem
{
    public class Generics
    {
        public static void ShowGenerics<T>(T[] items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
