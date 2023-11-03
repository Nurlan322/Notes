namespace Notebook.API.Models.DTO
{
    public class CreatNotesRequestDto
    {
        public string NoteTitle { get; set; } = null!;
        public string NoteText { get; set; } = null!;
        public string NoteTag { get; set; } = null!;
        public DateTime NoteDate { get; set; }
    }
}
