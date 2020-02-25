using Agenda.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;


namespace Agenda.InfraEstructure.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
            : base(AppDataContext)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
