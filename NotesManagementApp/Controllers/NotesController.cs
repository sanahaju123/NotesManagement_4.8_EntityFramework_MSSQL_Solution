using NotesManagement.Models;
using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NotesManagementApp.Controllers
{
    public class NotesController : ApiController
    {
        private readonly INotesService _service;
        public NotesController(INotesService service)
        {
            _service = service;
        }
        public NotesController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Notes/CreateNotes")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateNotes([FromBody] Notes model)
        {
            var leaveExists = await _service.GetNotesById(model.NotesId);
            var result = await _service.CreateNotes(model);
            return Ok(new Response { Status = "Success", Message = "Notes created successfully!" });
        }


        [HttpPut]
        [Route("api/Notes/UpdateNotes")]
        public async Task<IHttpActionResult> UpdateNotes([FromBody] Notes model)
        {
            var result = await _service.UpdateNotes(model);
            return Ok(new Response { Status = "Success", Message = "Notes updated successfully!" });
        }


        [HttpDelete]
        [Route("api/Notes/DeleteNotes")]
        public async Task<IHttpActionResult> DeleteNotes(long id)
        {
            var result = await _service.DeleteNotesById(id);
            return Ok(new Response { Status = "Success", Message = "Notes deleted successfully!" });
        }


        [HttpGet]
        [Route("api/Notes/GetNotesById")]
        public async Task<IHttpActionResult> GetNotesById(long id)
        {
            var expense = await _service.GetNotesById(id);
            return Ok(expense);
        }


        [HttpGet]
        [Route("api/Notes/GetAllNotess")]
        public async Task<IEnumerable<Notes>> GetAllNotess()
        {
            return _service.GetAllNotess();
        }
    }
}
