namespace Mc.Api.Core.Data
{
    using System.Threading.Tasks;
    using Mc.Api.Core.Models;

    public interface IDroidRepository
    {
        Task<Droid> Get(int id);
    }
}
