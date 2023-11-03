namespace AnnouncementAPI
{
    public class Announcement
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public Announcement()
        {
            Author = string.Empty;
            Date = DateTime.Now.Date;
            Subject = string.Empty;
            Body = string.Empty;
        }

        public Announcement(string author, string subject, string body)
        {
            Author = author;
            Date = DateTime.Now.Date;
            Subject = subject;
            Body = body;
        }
    }
}