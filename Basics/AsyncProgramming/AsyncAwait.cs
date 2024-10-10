namespace AsyncProgramming
{
    public class AsyncAwait
    {
        static async Task<string> FetchData(string url)
        {
            HttpClient client = new();

            return await client.GetStringAsync(url);
        }

        public static async Task ShowAsyncAwait()
        {
            Console.WriteLine("Fetching data...");

            string data = await FetchData("https://jsonplaceholder.typicode.com/posts/1");

            Console.WriteLine($"Data received: {data}");
        }
    }
}
