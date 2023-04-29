// See https://aka.ms/new-console-template for more information
using photo_export;

public class Program
{
    public async static Task Main(string[] args)
    {
        var apiInterface = new GoogleApiInterface();
        await apiInterface.CreateAlbum();
    }
}

