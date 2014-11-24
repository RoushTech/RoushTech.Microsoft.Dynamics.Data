namespace RoushTech.Microsoft.Dynamics.Data
{
    using System.Data.Entity;

    using RoushTech.Microsoft.Dynamics.Data.Inventory;

    public class DynamicsContext : DbContext
    {
        public DynamicsContext()
        {
        }

        public DynamicsContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public DbSet<ItemCurrencyMaster> ItemCurrencyMaster { get; set; }

        public DbSet<ItemPriceList> ItemPriceList { get; set; }

        public DbSet<ItemPriceListOptions> ItemPriceListOptions { get; set; } 
    }
}
