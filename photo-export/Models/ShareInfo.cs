using System;
namespace photo_export.Models
{
    public class ShareInfo
    {
        public SharedAlbumOptions? SharedAlbumOptions { get; set; }
        public string? SharableUrl { get; set; }
        public string? ShareToken { get; set; }
        public bool? IsJoined { get; set; }
        public bool? IsOwned { get; set; }
        public bool? IsJoinble { get; set; }
    }
}