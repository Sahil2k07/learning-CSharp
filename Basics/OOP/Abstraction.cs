namespace OOP
{
    public abstract class Language
    {
        public abstract void ShowLanguage();
    }

    public class Csharp : Language
    {
        public override void ShowLanguage()
        {
            Console.WriteLine("Working on Csharp");
        }

        public static void ShowAbstraction()
        {
            var lan = new Csharp();

            lan.ShowLanguage();
        }
    }
}
