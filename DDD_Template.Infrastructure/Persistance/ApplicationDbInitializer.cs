using Microsoft.EntityFrameworkCore;

namespace DDD_Template.Infrastructure.Persistance
{
    internal class ApplicationDbInitializer : IInitializer
    {
        private readonly ApplicationDbContext db;

        public ApplicationDbInitializer(ApplicationDbContext db) => this.db = db;

        public void Initialize() => this.db.Database.Migrate();
    }
}
