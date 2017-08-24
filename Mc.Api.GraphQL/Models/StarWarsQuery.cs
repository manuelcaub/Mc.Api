namespace Mc.Api.Models
{
    using GraphQL.Types;
    using Mc.Api.Core.Data;

    public class StarWarsQuery : ObjectGraphType
    {
        private IDroidRepository _droidRepository;

        public StarWarsQuery(IDroidRepository droidRepository)
        {
            Field<DroidType>(
              "hero",
              resolve: context => droidRepository.Get(1));
        }
    }
}
