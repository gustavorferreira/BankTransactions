using Microsoft.EntityFrameworkCore;
using BankTransactions.Models;

namespace BankTransactions.Contexts
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) 
            : base(options)
        { }

        public DbSet<TransactionModel> Transactions { get; set; }
    }
}
