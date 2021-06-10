using Microsoft.EntityFrameworkCore;
using System;

namespace APIRest01.Model.Context {
    public class MysqlContext : DbContext {
        public MysqlContext() {

        }

        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

    }
}