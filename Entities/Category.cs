namespace APICatalogo.Entities;

public interface Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
}
