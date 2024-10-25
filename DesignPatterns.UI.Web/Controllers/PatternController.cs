using DesignPatterns.UI.Web.Helpers.Patterns;
using DesignPatterns.UI.Web.Models.Request;
using DesignPatterns.UI.Web.Models.Result;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.UI.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatternController : ControllerBase
    {
        [HttpPost]
        public string ExecutePattern([FromBody]RequestModel model)
        {
            var pattern = new PatternHelperFactory().GetFactoryClass(model);

            string result = null;
            
            if(pattern != null)
            {
                result = pattern.ExecutePatternImplementation(model.JsonData);
            }

            return result;
        }
    }
}
