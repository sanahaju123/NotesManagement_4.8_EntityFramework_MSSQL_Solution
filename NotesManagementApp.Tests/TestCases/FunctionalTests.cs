

using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.DAL.Services;
using NotesManagementApp.DAL.Services.Repository;
using NotesManagementApp.Models;
using NotesManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Notes = NotesManagementApp.Models.Notes;

namespace NotesManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly INotesService _notesService;
        public readonly Mock<INotesRepository> notesservice = new Mock<INotesRepository>();

        private readonly Notes _notes;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
        {
            _notesService = new NotesService(notesservice.Object);

            _output = output;

            _notes = new Notes
            {
                NotesId = 1,
                Name = "Sample Notes",
                DateCreated = DateTime.Now,
                Description = "This is a sample notes."
            };
        }


        [Fact]
        public async Task<bool> Testfor_Create_Notes()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repos => repos.CreateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.CreateNotes(_notes);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }


        [Fact]
        public async Task<bool> Testfor_Update_Notes()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repos => repos.UpdateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.UpdateNotes(_notes);
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");

            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_GetNotesById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repos => repos.GetNotesById(id)).ReturnsAsync(_notes);
                var result = await _notesService.GetNotesById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_DeleteNotesById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repos => repos.DeleteNotesById(id)).ReturnsAsync(response);
                var result = await _notesService.DeleteNotesById(id);
                //Assertion
                if (result != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}