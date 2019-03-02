using Algolia.Search.Clients;
using Algolia.Search.Models.Settings;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Algolia.WebAPI.Controllers
{
    [Route("api/settings")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private ISearchIndex _index;

        public SettingController(ISearchIndex index)
        {
            _index = index;
        }

        [HttpGet]
        public async Task<ActionResult<IndexSettings>> GetSettings()
        {
            var response = await _index.GetSettingsAsync();
            return Ok(response);
        }
    }
}