using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notebook.API.Models.DTO;
using Notebook.API.Models.Domain;
using Notebook.API.Data;
using Notebook.API.Repositories.Interface;

namespace Notebook.API.Controllers
{
    // https://localhost:xxxx/api/notes
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesRepository notesRepository;
        public NotesController(INotesRepository notesRepository) 
        {
            this.notesRepository = notesRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreatNote(CreatNotesRequestDto request)
        {
            var notes = new Notes
            {
                NoteTitle = request.NoteTitle,
                NoteText = request.NoteText,
                NoteTag = request.NoteTag,
                NoteDate = request.NoteDate
            };

            await notesRepository.CreateAsync(notes);

            var response = new NotesDto
            {
                Id = notes.Id,
                NoteTitle = notes.NoteTitle,
                NoteText = notes.NoteText,
                NoteTag = notes.NoteTag,
                NoteDate = notes.NoteDate
            };

            return Ok(response);
        }

    }
}
