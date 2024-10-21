using System.ComponentModel.DataAnnotations;

namespace VueAspCoreProject.Server.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public string? NoteName { get; set; }
        public string? NoteContent { get; set; }
        public string? NoteColor { get; set; }

    }
}
