using System;
using System.ComponentModel.DataAnnotations;

namespace _3D.Test.App.Data.Models
{
    public class Message
    {
        [Required]
        public string ProfileName { get; set; }
        [Required]
        public string Recipient { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Body { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DateSent { get; set; }

    }
}
