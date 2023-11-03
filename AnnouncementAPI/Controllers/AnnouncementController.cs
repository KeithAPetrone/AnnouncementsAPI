using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
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

        /// <summary>
        /// Returns a subset of announements.
        /// </summary>
        /// <param name="numPerPage">The amount of announcements per page.</param>
        /// <param name="pageNum">The current page.</param>
        [SwaggerOperation(Summary = "Gets a subset of announcements.")]
        [Route("/get")]
        [HttpGet]
        public IEnumerable<Announcement> Get(int numPerPage, int pageNum)
        {
            return announcements.GetAnnouncements(numPerPage, pageNum);
        }

        /// <summary>
        /// Creates an announcement.
        /// </summary>
        /// <param name="author">The creator of the announcement.</param>
        /// <param name="subject">The subject of the announcement.</param>
        /// <param name="body">The contents of the announcement in Markdown format.</param>
        [SwaggerOperation(Summary = "Creates an announcement.")]
        [Route("/create")]
        [HttpPost]
        public void Create(string author, string subject, string body)
        {
            Announcement announcement = new Announcement(author, subject, body);
            announcements.CreateAnnouncement(announcement);
        }

        /// <summary>
        /// Deletes an announcement.
        /// </summary>
        /// <param name="subject">The subject of the announcement.</param>
        [SwaggerOperation(Summary = "Deletes an announcement.")]
        [Route("/delete")]
        [HttpPost]
        public void Delete(string subject)
        {
            announcements.DeleteAnnouncement(subject);
        }

        /// <summary>
        /// Deletes an announcement.
        /// </summary>
        /// <param name="subject">The subject of the announcement.</param>
        /// /// <param name="body">The contents of the announcement in Markdown format.</param>
        [SwaggerOperation(Summary = "Updates an announcement.")]
        [Route("/update")]
        [HttpPost]
        public void Update(string subject, string body)
        {
            announcements.UpdateAnnouncement(subject, body);
        }
    }
}