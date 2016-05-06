using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CodeFirst.Domian;

namespace CodeFirst.Infrastructure
{
    public class AccountsDBContext : DbContext
    {
        public AccountsDBContext() : base("AccountsTable")
        {
        }

        public IDbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Account>()
                 .HasKey(a => a.UserId);
        }
    }
}