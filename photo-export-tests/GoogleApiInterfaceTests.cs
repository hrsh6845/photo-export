using photo_export;

namespace photo_export_tests;

public class GoogleApiInterfaceTests
{
    private GoogleApiInterface _photo;

    [SetUp]
    public void Setup()
    {
        _photo = new GoogleApiInterface();
    }

    [Test]
    public async Task CanGetAlbums()
    {
        var albums = await _photo.CreateAlbum();

        Assert.IsTrue(albums.Any());
    }
}
