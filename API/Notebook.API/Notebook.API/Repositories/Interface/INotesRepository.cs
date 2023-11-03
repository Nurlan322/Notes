using Notebook.API.Models.Domain;

namespace Notebook.API.Repositories.Interface
{
    public interface INotesRepository
    {
        Task<Notes> CreateAsync(Notes notes);
    }
}
