using Microsoft.AspNetCore.Mvc;
using VueAspCoreProject.Server.Models;
using VueAspCoreProject.Server.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VueAspCoreProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly ILogger<NoteController> _logger;

        public NoteController(ILogger<NoteController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Note> Get()
        {
            var notes = _context.Notes.ToList();
            return notes;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Note Get(int id)
        {
            var note = _context.Notes.FirstOrDefault(e => e.NoteId == id);
            return note;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Note value)
        {
            _context.Notes.Add(value);

            _context.SaveChanges();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            var note = _context.Notes.FirstOrDefault(note => note.NoteId == id);
            note.NoteContent = value;

            _context.SaveChanges();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var note = _context.Notes.FirstOrDefault(note => note.NoteId == id);
            _context.Remove(note);
            _context.SaveChanges();
        }
    }
}
