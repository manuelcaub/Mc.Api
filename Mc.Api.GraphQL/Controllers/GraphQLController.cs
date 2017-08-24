﻿namespace Mc.Api.Controllers
{
    using System.Threading.Tasks;
    using GraphQL;
    using GraphQL.Types;
    using Mc.Api.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("graphql")]
    public class GraphQLController : Controller
    {
        private readonly StarWarsQuery _starWarsQuery;

        public GraphQLController(StarWarsQuery starWarsQuery)
        {
            _starWarsQuery = starWarsQuery;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var schema = new Schema { Query = _starWarsQuery };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;

            }).ConfigureAwait(false);

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
