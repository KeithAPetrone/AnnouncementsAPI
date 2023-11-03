using static System.Reflection.Metadata.BlobBuilder;

namespace AnnouncementAPI
{
    public class AnnouncementSingleton
    {
        private List<Announcement> _announcements;

        public AnnouncementSingleton()
        {
            _announcements = new List<Announcement>();
            _announcements.Add(new Announcement("test", "test", "test"));
        }

        public List<Announcement> GetAnnouncements(int numPerPage, int pageNum)
        {
            List<Announcement> result = _announcements.GetRange(pageNum, numPerPage);
            return _announcements;
        }

        public void CreateAnnouncement(Announcement announcement)
        {
            _announcements.Add(announcement);
        }

        public void DeleteAnnouncement(string subject)
        {
            _announcements.RemoveAll(x => x.Subject == subject);
        }

        public void UpdateAnnouncement(string subject, string body)
        {
            _announcements.FirstOrDefault(X => X.Subject == subject).Body = body;
        }
    }
}
