using System;
using System.ComponentModel.DataAnnotations;

namespace SpiritChat.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
