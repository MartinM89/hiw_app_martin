using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cart
{
    [Key]
    public string Email { get; set; } = default!;

    [ForeignKey(nameof(User))]
    public string EmailFK { get; set; } = default!;

    public User User { get; set; } = default!;

    public ICollection<ProductCart> ProductCarts { get; set; } = new List<ProductCart>();

    public Cart(string email, string emailFk)
    {
        Email = email;
        EmailFK = emailFk;
    }

    public Cart() { }
}
