namespace OOP
{
    public class Book
    {
        public virtual void ReadBook()
        {
            Console.WriteLine("Reading Book");
        }
    }

    public class HarryPotter : Book
    {
        public override void ReadBook()
        {
            Console.WriteLine("Reading Harry Potter");
        }

        public static void ShowPolymorphism()
        {
            var hp = new HarryPotter();
            hp.ReadBook();
        }
    }
}
