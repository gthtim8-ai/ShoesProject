namespace ShoesProject.Models;

public partial class DeliveryPoint
{
    public int Id { get; set; }

    public string DeliveryAdress { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
