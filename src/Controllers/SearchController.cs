using Algolia.Search.Clients;
using Algolia.Search.Models.Search;
using Algolia.WebAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Algolia.WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private ISearchIndex _index;

        public SearchController(ISearchIndex index)
        {
            _index = index;
        }

        [HttpPost]
        [Route("search/actors")]
        public async Task<ActionResult<IEnumerable<Actor>>> Search(Query query)
        {
            var response = await _index.SearchAsync<Actor>(query);
            return Ok(response);
        }
    }
}