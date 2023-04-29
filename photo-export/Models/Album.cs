using System;
namespace photo_export.Models
{
    public class Album
    {
        public string? Id { get; set; }
        public string? Title { get; set; }
        public string? ProductrUrl { get; set; }
        public bool? IsWriteable { get; set; }
        public ShareInfo? ShareInfo { get; set; }
        public string? MediaItemsCount { get; set; }
        public string? CoverPhotoBaseUrl { get; set; }
        public string? CoverPhotoMediaItemId { get; set; }
    }
}

