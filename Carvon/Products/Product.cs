using Carvon.Commons;

namespace Carvon.Products;

public class Product : Auditable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public long CategoryId { get; set; }
    public ProductCategory Category { get; set; }
}
