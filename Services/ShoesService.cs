using System;
using System.Collections.Generic;
using shoestore.Models;
using shoestore.Repositories;

namespace shoestore.Services
{
  public class ShoesService
  {
    private readonly ShoesRepository _repo;
    public ShoesService(ShoesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Shoe> Get()
    {
      return _repo.Get();
    }

    internal Shoe Get(int id)
    {
      Shoe found = _repo.Get(id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }

      return found;
    }

    internal Shoe Create(newShoe)
    {
      Shoe created = _repo.Create(newShoe);
      if (created == null)
      {
        throw new Exception("Create Requst Failed");
      }
      return created;
    }


  }
}