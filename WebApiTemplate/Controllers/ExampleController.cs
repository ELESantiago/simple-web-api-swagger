using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiTemplate.Controllers
{
    [Produces("application/json")]
    [ApiConventionType(typeof(DefaultApiConventions))] // with this there is not necessary to apply it to each method
    [ApiController]
    [Route("[controller]")]
    public class ExampleController: ControllerBase
    {
        /// <summary>
        /// Get all examples
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Get))]
        public ActionResult<IEnumerable<Example>> GetAllExamples()
        {
            return Ok(Examples.ExampleList);
        }

        /// <summary>
        /// Create a new example
        /// </summary>
        /// <param name="example"></param>
        /// <returns>A string with the word success</returns>
        /// <response code="201">Returns success</response>
        /// <response code="400">If something goes wrong</response>
        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Post))]
        public ActionResult<string> CreateExample([FromBody] Example example)
        {
            return CreatedAtRoute("GetExample", new { id = 1 }, "Success");
        }

        /// <summary>
        /// Get an Example by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>The corresponding example object</returns>
        /// <response code="201">Returns success</response>
        /// <response code="400">If something goes wrong</response>
        /// <response code="404">If the id doesn't correspond to any registry</response>
        [HttpGet("{id}")]
        [ApiConventionMethod(typeof(DefaultApiConventions),
                     nameof(DefaultApiConventions.Get))]
        public ActionResult<Example> GetExample(int id)
        {
            var examples = Examples.ExampleList.ToList();
            var example = examples.Find(e => e.Id == id);
            if (example == null)
            {
                return NotFound();
            }
            return Ok(example);
        }
    }
}
