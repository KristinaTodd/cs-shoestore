namespace shoestore.Repositories
{
  public class ShoesRepository
  {

    private readonly IDbConnection _db
    public ShoesRepository(IDbConnection db)
    {
      _db = db;
    }
  }

}