using System.Data.Entity;
using CST356_Lab_5.Data.Entities;

namespace CST356_Lab_5.Data
{
    public interface IDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Pet> Pets { get; set; }
    }
}
