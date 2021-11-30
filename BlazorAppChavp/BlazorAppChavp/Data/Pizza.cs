namespace BlazorAppChavp.Data
{
    using System.ComponentModel.DataAnnotations;

    public class Pizza
    {
        public int PizzaId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(10.00, 25.00)]
        public decimal Price { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public int SpecialId { get; set; }
        public PizzaSpecial Special { get; set; }

        public int MinimumSize { get; set; }
        public int MaximumSize { get; set; }
        public int Size { get; set; }

        public string GetFormattedTotalPrice() => Special.GetFormattedBasePrice();

        public static int DefaultSize { get; set; } = 1;

        public List<PizzaTopping> Toppings { get; set; }
    }
}
