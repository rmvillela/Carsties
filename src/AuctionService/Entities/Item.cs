using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;


/** já que Item está relacionado ao Auction, não é necessário declarar no AuctionDbContext, 
    apenas informar que o nome deve ser criado em plural na base através desta linha 
*/
[Table("Items")] 
public class Item
{
  public Guid Id { get; set; }
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public string Color { get; set; }
  public int Mileage { get; set; }
  public string ImageUrl { get; set; }

  // nav properties - permite que o entity reconheça uma relação 1 - 1 entre Auction e Item
  public Auction Auction { get; set; }
  public Guid AuctionId { get; set; }
}
