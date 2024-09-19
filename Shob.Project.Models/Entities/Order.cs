namespace Shob.Project.Models.Entities;

public class Order : BaseEntity
{
    public string Adress { get; set; }

    public ICollection<Product> Products { get; set; }
}
