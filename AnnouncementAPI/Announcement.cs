using Markdig;
using Markdig.Syntax;

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

        public Announcement(string announcement)
        {
            var document = Markdown.Parse(announcement);

            document.Select(b => b as HeadingBlock)
                            .Where(b => b != null)
                            .Select(hb => hb.Inline.FirstChild.ToString());

            //Author = author;
            Date = DateTime.Now.Date;
            //Subject = subject;
            //Body = body;
        }
    }
}