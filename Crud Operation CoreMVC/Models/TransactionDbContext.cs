using Microsoft.EntityFrameworkCore;

namespace Crud_Operation_CoreMVC.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options):base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set;}
    }
}
