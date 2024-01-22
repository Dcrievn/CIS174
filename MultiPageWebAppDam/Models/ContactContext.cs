using Microsoft.EntityFrameworkCore;

namespace MultiPageWebAppDam.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
        : base(options)
        { }
        public DbSet<ContactInfo> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactInfo>().HasData(
            new ContactInfo
            {
                ContactID = 1,
                Name = "Willem Dafoe",
                PhoneNumber = "917-555-1234",
                Address = "68 Jane Street",
                Note = "Green Goblin"
            }
            );
        }
    }
}
