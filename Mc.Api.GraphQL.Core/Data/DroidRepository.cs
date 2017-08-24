namespace Mc.Api.Core.Data.InMemory
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mc.Api.Core.Models;

    public class DroidRepository : IDroidRepository
    {
        private List<Droid> _droids = new List<Droid>
        {
            new Droid { Id = 1, Name = "R2-D2" }
        };

        public Task<Droid> Get(int id)
        {
            return Task.FromResult(_droids.FirstOrDefault(droid => droid.Id == id));
        }
    }
}
