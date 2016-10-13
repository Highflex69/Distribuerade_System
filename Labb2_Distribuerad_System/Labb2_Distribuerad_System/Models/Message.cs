using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Labb2_Distribuerad_System.Models
{
    public class Message
    {
        
        public int MessageId { get; set; }
        public bool Isread { get; set; }
        public virtual User To { get; set; }
        public virtual User From { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsRemoved { get; set; }
    }

    public class MessageDBContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}