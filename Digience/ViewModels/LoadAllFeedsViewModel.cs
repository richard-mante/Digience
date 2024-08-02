
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Digience.Models;
using System.Collections.ObjectModel;

namespace Digience.ViewModels
{
    public partial class LoadAllFeedsViewModel : ObservableObject
    {
        [ObservableProperty]
        private Feed _oneFeed = new Feed
        {
            Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/a/1/4/a14178af-d267-4ebe-a6c5-66448b3b0271_large/playful-learning-moment-stockcake.jpg" },
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/a/1/4/a14178af-d267-4ebe-a6c5-66448b3b0271_large/playful-learning-moment-stockcake.jpg" }
                },
            PostInformation = "This is the second post information.",
            PostTitle = "Second Post",
            PostDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
            Owner = new Owner
            {
                OfficialName = "Jane Smith",
                UserName = "janesmith",
                ProfilePicture = "https://images.stockcake.com/public/3/b/5/3b50bf85-54dc-445c-aa0c-da8399c19176_large/focused-gamer-profile-stockcake.jpg"
            }
        };


        [ObservableProperty]
        private ObservableCollection<Feed> _feeds = new ObservableCollection<Feed>
        {
            new Feed
        {
            Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/a/1/4/a14178af-d267-4ebe-a6c5-66448b3b0271_large/playful-learning-moment-stockcake.jpg" },
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/a/1/4/a14178af-d267-4ebe-a6c5-66448b3b0271_large/playful-learning-moment-stockcake.jpg" }
                },
            PostInformation = "This is the second post information.",
            PostTitle = "Second Post",
            PostDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
            Owner = new Owner
            {
                OfficialName = "Jane Smith",
                UserName = "janesmith",
                ProfilePicture = "https://images.stockcake.com/public/b/e/6/be69f151-51a5-437a-a5dc-b997d49fc6d5_large/majestic-reindeer-silhouette-stockcake.jpg"
            }
        },
            new Feed
            {
                Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/b/c/d/bcddd99f-abf5-4cfe-9f9e-209311133ac3_large/playful-kittens-playing-stockcake.jpg" }
                },
                PostInformation = "This is the first post information.",
                PostTitle = "First Post",
                PostDate = DateTime.Now.ToString("yyyy-MM-dd"),
                Owner = new Owner
                {
                    OfficialName = "John Doe",
                    UserName = "johndoe",
                    ProfilePicture = "https://images.stockcake.com/public/0/a/d/0ad99758-634f-4a2d-9d10-33a0987bb782_large/rainy-reflection-contemplation-stockcake.jpg"
                }
            },
            new Feed
            {
                Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/a/1/4/a14178af-d267-4ebe-a6c5-66448b3b0271_large/playful-learning-moment-stockcake.jpg" }
                },
                PostInformation = "This is the second post information.",
                PostTitle = "Second Post",
                PostDate = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd"),
                Owner = new Owner
                {
                    OfficialName = "Jane Smith",
                    UserName = "janesmith",
                    ProfilePicture = "https://images.stockcake.com/public/4/9/8/49852b44-949e-4666-b076-e639d47fb205_large/contemplative-creative-chaos-stockcake.jpg"
                }
            },
            new Feed
            {
                Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/5/7/c/57c6b84d-16b1-43a0-bce2-c5a1854be3bf_large/explosive-drum-solo-stockcake.jpg" },
                },
                PostInformation = "This is the third post information.",
                PostTitle = "Third Post",
                PostDate = DateTime.Now.AddDays(-2).ToString("yyyy-MM-dd"),
                Owner = new Owner
                {
                    OfficialName = "Alice Johnson",
                    UserName = "alicejohnson",
                    ProfilePicture = "https://images.stockcake.com/public/9/7/3/97307c7f-d730-43e7-a65a-de9a8055a0b9_large/sunset-silhouette-portrait-stockcake.jpg"
                }
            },
            new Feed
            {
                Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/e/7/0/e7006e40-0979-43d8-8b07-b0e0588a3535_large/chef-prepares-vegetables-stockcake.jpg" }
                },
                PostInformation = "This is the fourth post information.",
                PostTitle = "Fourth Post",
                PostDate = DateTime.Now.AddDays(-3).ToString("yyyy-MM-dd"),
                Owner = new Owner
                {
                    OfficialName = "Bob Brown",
                    UserName = "bobbrown",
                    ProfilePicture = "https://example.com/profile4.jpg"
                }
            },
            new Feed
            {
                Files = new List<ImageInfo>
                {
                    new ImageInfo { LinkToImage = "https://images.stockcake.com/public/c/2/0/c20c73d3-b844-4280-9bba-35f5fc293a1d_large/vibrant-art-exhibit-stockcake.jpg" }
                },
                PostInformation = "This is the fifth post information.",
                PostTitle = "Fifth Post",
                PostDate = DateTime.Now.AddDays(-4).ToString("yyyy-MM-dd"),
                Owner = new Owner
                {
                    OfficialName = "Charlie Davis",
                    UserName = "charliedavis",
                    ProfilePicture = "https://images.stockcake.com/public/0/1/a/01a44504-5cf6-4d5c-84e1-d4275a9ff1d4_large/elderly-wisdom-glows-stockcake.jpg"
                }
            }
        };
    }
}
