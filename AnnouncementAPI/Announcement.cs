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
            Date = DateTime.Now;
            Subject = string.Empty;
            Body = string.Empty;
        }

        public Announcement(string author, DateTime date, string subject, string body)
        {
            Author = author;
            Date = date;
            Subject = subject;
            Body = body;
        }
    }
}