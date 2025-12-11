using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Logging all environment variables:");
        var assembly = Assembly.GetExecutingAssembly();
        var apiKey = Assembly.GetExecutingAssembly()
            .GetCustomAttributes<AssemblyMetadataAttribute>()
            .FirstOrDefault(a => a.Key == "Version")?.Value;

        Console.WriteLine($"API Key: {apiKey ?? "not set"}");
    }
}