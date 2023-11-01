using Microsoft.AspNetCore.Mvc;

namespace AnnouncementAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly ILogger<AnnouncementController> _logger;

        public AnnouncementController(ILogger<AnnouncementController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetAnnouncement")]
        public IEnumerable<Announcement> Get()
        {
            yield return new Announcement();
        }

        [HttpPost(Name = "CreateAnnouncement")]
        public IEnumerable<Announcement> Create(string author, DateTime date, string subject, string body)
        {
            Announcement announcement = new Announcement(author, date, subject, body);
            yield return new Announcement();
        }

        [HttpPost(Name = "UpdateAnnouncement")]
        public IEnumerable<Announcement> Update(string author, DateTime date, string subject, string body)
        {
            Announcement announcement = new Announcement(author, date, subject, body);
            yield return new Announcement();
        }

        [HttpPost(Name = "DeleteAnnouncement")]
        public IEnumerable<Announcement> Delete(string author, DateTime date, string subject, string body)
        {
            Announcement announcement = new Announcement(author, date, subject, body);
            yield return new Announcement();
        }
    }
}