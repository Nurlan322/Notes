using System.ComponentModel.DataAnnotations;

namespace Notebook.API.Models.Domain
{
    public class Notes
    {
        public Guid Id { get; set; }
        public string NoteTitle { get; set; } = null!;
        public string NoteText { get; set; } = null!;
        public string NoteTag { get; set; } = null!;
        public DateTime NoteDate { get; set; }
    }
}
