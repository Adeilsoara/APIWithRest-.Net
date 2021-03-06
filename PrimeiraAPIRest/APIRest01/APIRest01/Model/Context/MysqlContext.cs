using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace APIRest01.Model.Context {
    public class MysqlContext : DbContext {
        public MysqlContext() {

        }

        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }

      
    }
}