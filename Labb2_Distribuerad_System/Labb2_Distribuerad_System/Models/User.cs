using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Labb2_Distribuerad_System.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        
        public int NoOfLoginsThisMonth { get; set; }
        public int NoOfUnreadMessages { get; set; }
        public virtual List<Message> Messages { get; set; }

        public User()
        {
            this.LastLogin = DateTime.Now;
            this.NoOfLoginsThisMonth = 0;
            this.NoOfUnreadMessages = 0;
        }
    }

    public class UserDBContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
    }
}