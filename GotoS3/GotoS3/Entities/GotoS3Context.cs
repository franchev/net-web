using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GotoS3.API.Entities
{
    public class GotoS3Context: DbContext
    {
        public GotoS3Context(DbContextOptions<GotoS3Context> options): base(options)
        {
            Database.Migrate();
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Encryptor> Encryptors { get; set; }

    }
}
