using Avalonia.Media.Imaging;
using Avalonia.Platform;
using System.Reflection;

namespace ControlGallery;

public static class ImageHelper
{
    public static Bitmap LoadFromResource(Uri resourceUri)
    {
        return new Bitmap(AssetLoader.Open(resourceUri));
    }

    public static Bitmap LoadFromResource(string resourceUri)
    {
        return LoadFromResource(new Uri($"avares://{Assembly.GetEntryAssembly().GetName().Name}/Resources/Images/{resourceUri}", UriKind.Absolute));
    }

    public static Bitmap? LoadFromWebString(string url)
    {
        using var httpClient = new HttpClient();
        try
        {
            var response = httpClient.GetAsync(url).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            var data = response.Content.ReadAsStream();
            return new Bitmap(data);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred while downloading image '{url}' : {ex.Message}");
            return null;
        }
    }

    public static async Task<Bitmap?> LoadFromWeb(Uri url)
    {
        using var httpClient = new HttpClient();
        try
        {
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsByteArrayAsync();
            return new Bitmap(new MemoryStream(data));
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred while downloading image '{url}' : {ex.Message}");
            return null;
        }
    }
}