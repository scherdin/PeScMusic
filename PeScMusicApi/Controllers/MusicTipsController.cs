using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeScMusicService;
using PeScMusicService.Application;
using PeScMusicService.Repository;

namespace PeScMusicApi.Controllers
{
  [Route("api/[controller]")]
  public class MusicTipsController : Controller
  {
    private readonly IMusicTipsRepository _repository;
    private readonly IMusicTipsApplication _application;

    public MusicTipsController(IMusicTipsRepository repository, IMusicTipsApplication application)
    {
      _repository = repository;
      _application = application;
    }

    // GET api/values
    [HttpGet]
    [Route("Artist/{artistId}")]
    public IActionResult GetByaArtist(string artistId)
    {
      if (string.IsNullOrEmpty(artistId))
      {
        return BadRequest();
      }

      var tips = _application.GetByArtistId(artistId);
      return Json(tips);
    }

    // GET api/values/5
    [HttpGet("{id}", Name = "Get")]
    public IActionResult Get(int id)
    {
      if (id < 1)
      {
        return BadRequest();
      }

      var tips = _application.GetById(id);
      return Json(tips);
    }
    // POST api/values
    [HttpPost]
    public IActionResult Post([FromBody]Tips value)
    {
      if (value == null)
      {
        return BadRequest();
      }

      var id = _application.Save(value);

      //return Ok();
      return CreatedAtRoute("Get", new { id = id }, value);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]Tips value)
    {
      if (value == null || value.Id != id)
      {
        return BadRequest();
      }
      _application.Save(value);
      return NoContent();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      if (id < 1)
      {
        return BadRequest();
      }
      _application.Delete(id);
      return NoContent();
    }
  }
}