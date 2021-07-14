using System;
using System.ComponentModel.DataAnnotations;

namespace _3D.Test.App.Data.Models
{
    public class Message
    {
        [Required]
        [EmailAddress(ErrorMessage = "Please enter a valid recipient email address")]
        public string Recipient { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Please provide a subject")]
        public string Subject { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "Please enter a message (300 character max)")]
        public string Body { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateSent { get; set; }

    }
}
