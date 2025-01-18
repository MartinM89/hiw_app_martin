using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = default!;

    [MaxLength(255)]
    public string Description { get; set; } = default!;

    [Required]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [Required]
    public int Inventory { get; set; }

    [Column(TypeName = "decimal(3, 1)")]
    public decimal Rating { get; set; }

    public ProductCategory Category { get; set; }

    [MaxLength(255)]
    public string TableOfContent { get; set; } = default!;

    public ICollection<ProductCart> ProductCarts { get; set; } = new List<ProductCart>();

    public Product(
        int id,
        string name,
        string description,
        decimal price,
        int inventory,
        decimal rating,
        ProductCategory category,
        string tableOfContent
    )
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Inventory = inventory;
        Rating = rating;
        Category = category;
        TableOfContent = tableOfContent;
    }

    // Empty constructor for EF
    public Product() { }

    public enum ProductCategory
    {
        Protein_Bars,
        Shakes,
    }

    public string ToStringAdmin()
    {
        string ratingString = Rating.ToString();
        ratingString = ratingString.Replace(',', '.');

        return $"\n {Name}:\n"
            + "  ----------------------------------\n"
            + $"  id: {Id}\n"
            + $"  Description: {Description}\n"
            + $"  Price: {Price:N2}\n"
            + $"  Amount: {Inventory}\n"
            + $"  Rating: {ratingString}/5.0\n"
            + $"  Product Category: {Category}\n"
            + $"  Table of content: {TableOfContent}\n"
            + "  ----------------------------------";
    }

    public override string ToString()
    {
        string maxRating = "/5.0";
        string currency = "SEK";
        string inventoryColor;

        string ratingString = Rating.ToString();
        ratingString = ratingString.Replace(',', '.');

        if (Inventory == 0)
        {
            inventoryColor = "\x1b[38;5;196m";
        }
        else if (Inventory >= 1 && Inventory <= 10)
        {
            inventoryColor = "\x1b[38;5;220m";
        }
        else
        {
            inventoryColor = "\x1b[38;5;40m";
        }

        if (Rating == 0)
        {
            return $"\n\n        ID: [{Id}]{"                                                                 "}"
                + "\n\t+-------------------------------------+------------------+\t\t"
                + $"\n\t| Name        : {Name, -21} | ~~~~~~~~~~~~~~~~ |\\\t\t"
                + $"\n\t| Description : {Description, -21} | ~~~~~~~~~~~~~~~~ ||\\\t\t"
                + $"\n\t| Price       : {Price} {currency, -15} | ~~~~~~~~~~~~~~~~ ||||\t\t"
                + $"\n\t| Inventory   : {inventoryColor}{Inventory, -21}\x1b[0m | ~~~~~~~~~~~~~~~~ ||||\t\t"
                + $"\n\t| Rating      : No Rating             | ~~~~~~~~~~~~~~~~ ||||\t\t"
                + "\n\t+-------------------------------------+-----------------+||||\t\t"
                + "\n\t \\   \x1b[38;5;240mTable of contents\x1b[0m                 \\ ~~~~~~~~~~~~~~~~ \\||\t\t"
                + $"\n\t  \\   \x1b[32;5;5;5mAdd to cart\x1b[0m                       \\ ~~~~~~~~~~~~~~~~ \\|\t\t"
                + "\n\t   +--------------------------------------------------------+\t\t\n\n";
        }

        return $"\n\n        ID: [{Id}]{"                                                                 "}"
            + "\n\t+-------------------------------------+------------------+\t\t"
            + $"\n\t| Name        : {Name, -21} | ~~~~~~~~~~~~~~~~ |\\\t\t"
            + $"\n\t| Description : {Description, -21} | ~~~~~~~~~~~~~~~~ ||\\\t\t"
            + $"\n\t| Price       : {Price} {currency, -15} | ~~~~~~~~~~~~~~~~ ||||\t\t"
            + $"\n\t| Inventory   : {inventoryColor}{Inventory, -21}\x1b[0m | ~~~~~~~~~~~~~~~~ ||||\t\t"
            + $"\n\t| Rating      : {ratingString}{maxRating, -18} | ~~~~~~~~~~~~~~~~ ||||\t\t"
            + "\n\t+-------------------------------------+-----------------+||||\t\t"
            + "\n\t \\   \x1b[38;5;240mTable of contents\x1b[0m                 \\ ~~~~~~~~~~~~~~~~ \\||\t\t"
            + $"\n\t  \\   \x1b[32;5;5;5mAdd to cart\x1b[0m                       \\ ~~~~~~~~~~~~~~~~ \\|\t\t"
            + "\n\t   +--------------------------------------------------------+\t\t\n\n";
    }
}
