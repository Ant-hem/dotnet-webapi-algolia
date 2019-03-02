using System.Collections.Generic;
using System.Threading.Tasks;
using Algolia.Search.Clients;
using Algolia.Search.Models.Rules;
using Microsoft.AspNetCore.Mvc;

namespace Algolia.WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class RuleController : ControllerBase
    {
        private ISearchIndex _index;

        public RuleController(ISearchIndex index)
        {
            _index = index;
        }

        [HttpPost]
        [Route("rules/search")]
        public async Task<ActionResult<IEnumerable<Rule>>> Search(RuleQuery query)
        {
            var response = await _index.SearchRuleAsync(query);
            return Ok(response);
        }
    }
}