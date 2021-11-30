namespace BlazorAppChavp.Data
{
    public class Order
    {
        public List<Pizza> Pizzas { get; set; }

        public DateTime CreatedTime { get; set; }

        public string GetFormattedTotalPrice()
        {
            var totalPrice = Pizzas.Sum(x => x.Price);
            return totalPrice.ToString("0.00");
        }
    }
}
