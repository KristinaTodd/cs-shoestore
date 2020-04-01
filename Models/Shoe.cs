using System.ComponentModel.DataAnnotations;


namespace shoestore.Models
{
  public class Shoe
  {
    public string Name { get; set; }
    public int Size { get; set; }
    public float Price { get; set; }
    [Required]
    public int Id { get; set; }

  }

}