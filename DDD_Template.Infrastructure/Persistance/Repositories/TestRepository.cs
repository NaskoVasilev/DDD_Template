using DDD_Template.Application.Features.Tests;
using DDD_Template.Application.Features.Tests.Queries.Search;
using DDD_Template.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDD_Template.Infrastructure.Persistance.Repositories
{
    internal class TestRepository : DataRepository<Test>, ITestRepository
    {
        private readonly ApplicationDbContext db;

        public TestRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db;
        }

        public async Task<int> Count(CancellationToken cancellationToken) =>
            await this.db.Tests.CountAsync();

        public async Task<IEnumerable<TestListingModel>> GetTestsByName(string? name)
        {
            var query = this.db.Tests.AsQueryable();
            if (!string.IsNullOrEmpty(name))
            {
                query = query
                    .Where(x => EF.Functions.Like(x.Name, $"%{name}%"));
            }

            return await query
                .Select(x => new TestListingModel(x.Name))
                .ToListAsync();
        }
    }
}
