using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace SpiritChat.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Messages = new List<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
