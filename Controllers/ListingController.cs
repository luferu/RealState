using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RealState.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RealState.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingController : ControllerBase
    {

        public List<Listing> lstListings = new List<Listing>
        {
            new Listing { Id="1",Title="Test 1", Description="description Test 1", Price=1},
            new Listing { Id="2",Title="Test 2", Description="description Test 2", Price=2},
            new Listing { Id="3",Title="Test 3", Description="description Test 3", Price=3}
        };
        // GET: api/<ListingController>
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Listing>>> GetAll()
        {
            return Ok(lstListings);
        }

        // GET api/<ListingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

      //  POST api/<ListingController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Listing listing)
        {
            //if(!Model.IsValid)
            //{
            //    return BadRequest();
            //}
            
          /// int newId=lstListings.Count>0 ? lstListings.Max(x => x.Id) : 1;

            lstListings.Add(listing);

            return Ok(lstListings);
            

        }

        //// PUT api/<ListingController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ListingController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
