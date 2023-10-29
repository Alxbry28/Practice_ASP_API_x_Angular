namespace CodePulse.API.Models.Domain
{
    public class BlogPost
    {
        public Guid Id { get; set; } // 1
        public string Title { get; set; } // 2
        public string ShortDescription { get; set; } // 3
        public string Content { get; set; } // 4
        public string FeaturedImgUrl { get; set; } // 5
        public string UrlHandle { get; set; }// 6
        public DateTime PublishDate { get; set; } // 7
        public string Author { get; set; } // 8
        public bool IsVisible { get; set; } // 9
    }
}
