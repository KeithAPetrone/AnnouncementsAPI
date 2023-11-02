namespace AnnouncementAPI
{
    public class AnnouncementSingleton
    {
        private List<Announcement> _announcements;

        public AnnouncementSingleton()
        {
            _announcements = new List<Announcement>();
            _announcements.Add(new Announcement("test"));
        }

        public List<Announcement> GetAnnouncements(int numPerPage, int pageNum)
        {
            List<Announcement> result = _announcements.GetRange(pageNum, numPerPage);
            return result;
        }

        public void CreateAnnouncement(Announcement announcement)
        {
            _announcements.Add(announcement);
        }


    }
}
