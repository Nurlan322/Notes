using Microsoft.EntityFrameworkCore;
using Notebook.API.Data;
using Notebook.API.Models.Domain;
using Notebook.API.Repositories.Interface;

namespace Notebook.API.Repositories.Implementation
{
    public class NotesRepository : INotesRepository
    {
        private readonly ApplicationDbContext dbContext;
        public NotesRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task<Notes> CreateAsync(Notes notes)
        {
            await dbContext.Note.AddAsync(notes);
            await dbContext.SaveChangesAsync();
        
            return notes;
        }
    }
}
