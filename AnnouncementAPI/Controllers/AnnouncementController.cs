using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AnnouncementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly ILogger<AnnouncementController> _logger;

        public static AnnouncementSingleton announcements = new AnnouncementSingleton();

        public AnnouncementController(ILogger<AnnouncementController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet(Name = "GetAnnouncements")]
        public IEnumerable<Announcement> Get(int numPerPage, int pageNum)
        {
            return announcements.GetAllAnnouncements(numPerPage, pageNum);
        }

        [HttpPost(Name = "CreateAnnouncement")]
        public void Create(string author, string subject, string body)
        {
            Announcement announcement = new Announcement(author, subject, body);
            announcements.CreateAnnouncement(announcement);
        }
    }
}