using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProductCart
{
    [Required]
    public string CartEmail { get; set; } = default!;

    [Required]
    public int ProductId { get; set; }

    [Required]
    public int Amount { get; set; }

    [ForeignKey(nameof(CartEmail))]
    public Cart Cart { get; set; } = default!;

    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; } = default!;

    public ProductCart(string cartEmail, int productId, int amount)
    {
        CartEmail = cartEmail;
        ProductId = productId;
        Amount = amount;
    }

    public ProductCart(string cartEmail, int productId)
    {
        CartEmail = cartEmail;
        ProductId = productId;
    }

    // Empty constructor for EF
    public ProductCart() { }
}
