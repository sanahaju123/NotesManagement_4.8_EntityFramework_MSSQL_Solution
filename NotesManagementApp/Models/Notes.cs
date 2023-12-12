using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NotesManagementApp.Models
{
    public class Notes
    {
        [Key]
        public int NotesId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Description { get; set; }
    }
}