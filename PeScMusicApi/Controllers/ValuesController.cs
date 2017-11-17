using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PeScMusicService;

namespace PeScMusicApi.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }

  [Route("api/[controller]")]
  public class MusicTipsController : Controller
  {

    // GET api/values
    [HttpGet]
    [Route("Artist/{artistId}")]
    public IEnumerable<Tips> GetByArtist(string artistId)
    {
      return new List<Tips>();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public Tips Get(int id)
    {
      return new Tips();
    }
    // POST api/values
    [HttpPost]
    public void Post([FromBody]Tips value)
    {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Tips value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
