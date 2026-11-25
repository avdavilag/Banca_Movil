using Accounts.Domain.Accounts;

using Microsoft.EntityFrameworkCore;

namespace Accounts.Infrastructure.Persistence
{
    public sealed class AccountsDbContext : DbContext
    {
        public AccountsDbContext(DbContextOptions<AccountsDbContext> options) : base(options)
        {
        }

        public DbSet<Account> Accounts => Set<Account>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("accounts");

            modelBuilder.Entity<Account>(b =>
            {
                b.ToTable("Accounts");
                b.HasKey(a => a.Id);
                b.Property(a => a.AccountNumber).HasMaxLength(20).IsRequired();
                b.HasIndex(a => a.AccountNumber).IsUnique();
                b.Property(a => a.Currency).HasMaxLength(3).IsFixedLength().IsRequired();
                b.Property(a => a.Balance).HasPrecision(18, 2);
            });
        }
    }
}