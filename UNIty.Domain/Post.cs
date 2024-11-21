namespace UNIty.Domain
{

    public class Post
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int AdminUserId { get; set; }
        public User AdminUser { get; set; }
    }
}
