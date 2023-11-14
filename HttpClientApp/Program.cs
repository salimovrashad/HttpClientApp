namespace HttpClientApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var client = new HttpClient();

            Console.WriteLine("Input the link: ");
            var result = await client.GetStringAsync(Console.ReadLine());
            Console.WriteLine(result);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}