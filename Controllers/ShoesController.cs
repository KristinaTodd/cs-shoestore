using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using shoestore.Services;
using shoestore.Models;

namespace shoestore.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class ShoesController : ControllerBase
  {
    private readonly ShoesService _ss;

    public ShoesController(ShoesService ss)
    {
      _ss = ss;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ShoesController>> Get()
    {
      try
      {
        return Ok(_ss.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }

    }
    [HttpGet("{id}")]
    public ActionResult<Shoe> Get(int id)
    {
      try
      {
        return Ok(_ss.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpPost("{id}")]
    public ActionResult<Shoe> Create([FromBody] Shoe newShoe)
    {
      try
      {
        return Ok(_ss.Create(newShoe));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }


    [HttpPut("{id}")]
    public ActionResult<Shoe> Edit(int id, [FromBody] Shoe updatedShoe)
    {
      try
      {
        return Ok(_ss.Edit(updatedShoe));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Shoe> Delete(int id)
    {
      try
      {
        return Ok(_ss.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}
