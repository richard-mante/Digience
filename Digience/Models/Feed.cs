namespace Digience.Models
{
    public class Feed
    {
        public List<ImageInfo>? Files { get; set; }
        public string? PostInformation { get; set; }
        public string? PostTitle { get; set; }
        public string PostDate { get; set; }
        public Owner Owner { get; set; }
    }

    public class Owner
    {
        public string? OfficialName { get; set; }
        public string? UserName { get; set; }
        public string? ProfilePicture { get; set; }

    }

    public class ImageInfo
    {
        public string LinkToImage { get; set; }

    }
}
