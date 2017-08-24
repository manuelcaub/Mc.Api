namespace Mc.Api.Core.Data.Repositories
{
    using System.Threading.Tasks;
    using Mc.Api.Core.Models;
    using Microsoft.EntityFrameworkCore;

    public class DroidRepository : IDroidRepository
    {
        private readonly DataBaseContext _db;

        public DroidRepository(DataBaseContext db)
        {
            _db = db;
        }

        public Task<Droid> Get(int id)
        {
            return _db.Droids.FirstOrDefaultAsync(droid => droid.Id == id);
        }
    }
}
