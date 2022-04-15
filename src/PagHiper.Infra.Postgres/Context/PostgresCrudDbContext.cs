using Microsoft.EntityFrameworkCore;
using PagHiper.Infra.Context;

namespace PagHiper.Infra.Postgres.Context
{
    public class PostgresCrudDbContext : CrudDbContext
    {
        public PostgresCrudDbContext(DbContextOptions options)
            : base(options) { }
    }
}