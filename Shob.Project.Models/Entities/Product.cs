namespace Shob.Project.Models.Entities;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public float Price { get; set; }

    //Foreign key
    public int CategoryId { get; set; }

    //Navigation property
    public Category Category { get; set; }
    public ICollection<Order> Orders { get; set; }


    public override string ToString()
    {
        return $"Id:{Id} - Name:{Name} ";
    }

}

