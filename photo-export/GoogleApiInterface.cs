using System;
using RestSharp;

namespace photo_export
{
    public class GoogleApiInterface
    {
        private RestClient _restClient;
        public GoogleApiInterface()
        {
            _restClient = new RestClient("https://photoslibrary.googleapis.com/v1/albums");
        }

        public async Task<IEnumerable<string>> CreateAlbum()
        {
            throw new NotImplementedException();
        }
    }
}

