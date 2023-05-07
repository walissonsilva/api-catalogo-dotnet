namespace APICatalogo.Entities;

public interface Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }
    public float Inventory { get; set; }
    public DateTime RegistrationDate { get; set; }
}
