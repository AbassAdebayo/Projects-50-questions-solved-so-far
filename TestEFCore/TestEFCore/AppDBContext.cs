using System;
using Microsoft.EntityFrameworkCore;
using TestEFCore.Entities;

namespace TestEFCore
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=bankapp;password=DefinedCode");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountHolder> AccountHolders { get; set; }
    }
}