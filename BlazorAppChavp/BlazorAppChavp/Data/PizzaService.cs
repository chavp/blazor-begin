namespace BlazorAppChavp.Data
{
    public class PizzaService
    {
        public async Task<Pizza[]> GetPizzasAsync()
        {
            // Call your data access technology here
            return new Pizza[]
            {
                new Pizza{ PizzaId = 1, Name = "001" },
                new Pizza{ PizzaId = 2, Name = "002" }
            };
        }
    }
}
