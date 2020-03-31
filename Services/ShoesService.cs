namespace shoestore.Services
{
  public class ShoesService
  {
    private readonly ShoesRepository _repo
    public ShoesService(ShoesRepository repo)
    {
      _repo = repo;
    }
  }
}