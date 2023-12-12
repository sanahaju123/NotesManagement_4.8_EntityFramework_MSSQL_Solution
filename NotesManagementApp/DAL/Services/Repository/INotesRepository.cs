using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesManagementApp.DAL.Services.Repository
{
    public interface INotesRepository
    {
        List<Notes> GetAllNotess();
        Task<Notes> CreateNotes(Notes expense);
        Task<Notes> GetNotesById(long id);
        Task<bool> DeleteNotesById(long id);
        Task<Notes> UpdateNotes(Notes model);
    }
}

