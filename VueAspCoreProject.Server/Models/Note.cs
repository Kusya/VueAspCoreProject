using System.ComponentModel.DataAnnotations;

namespace VueAspCoreProject.Server.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Content { get; set; }
        public string? Color { get; set; }
        public string? Type { get; set; }

    }
}
