using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.DAL.Services.Repository;
using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NotesManagementApp.DAL.Services
{
    public class NotesService : INotesService
    {
        private readonly INotesRepository _repository;

        public NotesService(INotesRepository repository)
        {
            _repository = repository;
        }

        public Task<Notes> CreateNotes(Notes expense)
        {
            return _repository.CreateNotes(expense);
        }

        public Task<bool> DeleteNotesById(long id)
        {
            return _repository.DeleteNotesById(id);
        }

        public List<Notes> GetAllNotess()
        {
            return _repository.GetAllNotess();
        }

        public Task<Notes> GetNotesById(long id)
        {
            return _repository.GetNotesById(id); ;
        }

        public Task<Notes> UpdateNotes(Notes model)
        {
            return _repository.UpdateNotes(model);
        }
    }
}