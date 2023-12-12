using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NotesManagementApp.DAL.Services.Repository
{
    public class NotesRepository : INotesRepository
    {
        private readonly DatabaseContext _dbContext;
        public NotesRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Notes> CreateNotes(Notes expense)
        {
            try
            {
                var result =  _dbContext.Notess.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteNotesById(long id)
        {
            try
            {
                _dbContext.Notess.Remove(_dbContext.Notess.Single(a => a.NotesId == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Notes> GetAllNotess()
        {
            try
            {
                var result = _dbContext.Notess.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Notes> GetNotesById(long id)
        {
            try
            {
                return await _dbContext.Notess.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Notes> UpdateNotes(Notes model)
        {
            var ex = await _dbContext.Notess.FindAsync(model.NotesId);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}