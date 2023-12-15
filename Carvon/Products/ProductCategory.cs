using Carvon.Commons;

namespace Carvon.Products;

public class ProductCategory : Auditable
{
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; }
}
