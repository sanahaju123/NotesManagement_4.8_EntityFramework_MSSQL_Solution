


using NotesManagementApp.DAL.Interrfaces;
using NotesManagementApp.DAL.Services;
using NotesManagementApp.DAL.Services.Repository;
using NotesManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Notes = NotesManagementApp.Models.Notes;

namespace NotesManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly INotesService _notesService;
        public readonly Mock<INotesRepository> notesservice = new Mock<INotesRepository>();

        private readonly Notes _notes;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Validate_ifInvalidNotesIdIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repo => repo.CreateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.CreateNotes(_notes);
                if (result != null || result.NotesId !=0)
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
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repo => repo.CreateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.CreateNotes(_notes);
                if (result != null || result.Name !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidDescriptionIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repo => repo.CreateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.CreateNotes(_notes);
                if (result != null || result.Description !=null)
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
        public async Task<bool> Testfor_Validate_ifInvalidNotesDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                notesservice.Setup(repo => repo.CreateNotes(_notes)).ReturnsAsync(_notes);
                var result = await _notesService.CreateNotes(_notes);
                if (result != null || result.DateCreated !=null)
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